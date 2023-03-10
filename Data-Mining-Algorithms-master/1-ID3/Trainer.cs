#region License
// ====================================================
// EasySSA Copyright(C) 2017 Furkan Türkal
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ID3 {
    public sealed class Trainer {

        private TrainingSet m_set;

        private List<EntryResult> m_results;

        public Trainer(TrainingSet set) {
            this.m_set = set;
            this.m_results = new List<EntryResult>();
        }

        public void TrainID3(TrainingSet set) {

            string master = this.CalculateHead(set);

            Console.WriteLine("HEAD NODE = " + master);
            Console.WriteLine();

            StringBuilder sb = new StringBuilder(1000);
            for (int i = 0; i < set.Entries.Length; i++) {

                TrainingEntry current = set.Entries[i];

                if (current.Name.Equals(master, StringComparison.InvariantCultureIgnoreCase)) {
                    for (int j = 0; j < current.Values.Length; j++) {
                        string currentName = current.Values[j];

                        TrainingSet currentExcept = this.GetExceptBranch(set, currentName);
                        string subBranch = CalculateHead(currentExcept);
                        string subName = currentName;

                        sb.AppendLine("+ VALUE = " + subName);
                        
                        if (!subBranch.Equals(master)) {
                            sb.AppendLine("|");
                            sb.AppendLine("|");
                            sb.AppendLine("--------- SUB NODE = " + subBranch);

                            PrintSubBranch(currentExcept, sb, subBranch);
                            //this.TrainID3(currentExcept);

                            sb.AppendLine("|");
                            sb.AppendLine("|");
                        } else {
                            sb.AppendLine("(" + CalculateResult(currentExcept, subName) + ")");
                        }
                        //Console.WriteLine("name = " + currentName + "\t\t sub = " + subName + " -- scale = " + currentScale);
                    }
                }
            }
            Console.WriteLine(sb.ToString());

        }

        public void PrintSubBranch(TrainingSet set, StringBuilder sb, string attibrute) {
            int index = GetEntryHeadIDFor(set, attibrute);
            for (int i = 0; i < this.m_set.Entries[index].Values.Length; i++) {
                string current = this.m_set.Entries[index].Values[i];

                TrainingSet h = GetExceptBranch(set, current);
                sb.AppendLine("\t\t" + attibrute + "-->" + current + " --> " + CalculateResult(h, current));
            }
        }

        public int GetEntryHeadIDFor(TrainingSet set, string entry) {
            for (int i = 0; i < this.m_set.Entries.Length; i++) {
                if (this.m_set.Entries[i].Name.Equals(entry, StringComparison.InvariantCultureIgnoreCase)) {
                    return i;
                }
            }
            return -1;
        }

        public int GetEntryIDFor(TrainingSet set, string entry) {
            for (int i = 0; i < this.m_set.Entries.Length; i++) {
                for (int j = 0; j < this.m_set.Entries[i].Values.Length; j++) {
                    if (this.m_set.Entries[i].Values[j].Equals(entry, StringComparison.InvariantCultureIgnoreCase)) {
                        return i;
                    }
                }
            }
            return -1;
        }

        public double GetBranchEarningScale(TrainingSet set, int index) {

            int totalEntries = set.Entries.Length;

            int totalOutCount = set.Entries[index].Values.Length;

            string[] entryValues = set.Entries[index].Values;

            //ISI soğuk, ılık, sıcak --- 4, 6, 4
            Dictionary<string, int> outCountsTrue = new Dictionary<string, int>(totalOutCount);
            Dictionary<string, int> outCountsFalse = new Dictionary<string, int>(totalOutCount);

            for (int i = 0; i < set.Samples.Count; i++) {
                string currentSample = set.Samples[i].Samples[index];

                bool including = entryValues.Any(s => s.Equals(currentSample, StringComparison.InvariantCultureIgnoreCase));

                if (including) {
                    if (set.Samples[i].Output) {
                        if (!outCountsTrue.ContainsKey(currentSample)) {
                            outCountsTrue.Add(currentSample, 1);
                        } else {
                            outCountsTrue[currentSample]++;
                        }
                    } else {
                        if (!outCountsFalse.ContainsKey(currentSample)) {
                            outCountsFalse.Add(currentSample, 1);
                        } else {
                            outCountsFalse[currentSample]++;
                        }
                    }
                }

            }

            double totalH = 0.0d;

            //Yüksek olanı al ?

            if (outCountsTrue.Count > 0 && outCountsFalse.Count == 0) {
                return 1.0d;
            } else if (outCountsTrue.Count == 0 && outCountsFalse.Count > 0) {
                return 0.0d;
            }

            foreach (KeyValuePair<string, int> kvp in outCountsTrue) {

                int countTrue = 0;
                int countFalse = 0;

                if (outCountsTrue.ContainsKey(kvp.Key)) {
                    countTrue = outCountsTrue[kvp.Key];
                }

                if (outCountsFalse.ContainsKey(kvp.Key)) {
                    countFalse = outCountsFalse[kvp.Key];
                }

                int countTotal = countTrue + countFalse;


                double currentH = 0.0d;

                if(countTrue == 0 && countFalse > 0) {
                    currentH = this.CalculateH(countFalse / (double)countTotal, countFalse / (double)countTotal);
                } else if (countTrue > 0 && countFalse > 0) {
                    currentH = this.CalculateH(countTrue  / (double)countTotal, countFalse / (double)countTotal);
                } else if (countTrue > 0 && countFalse == 0) {
                    currentH = this.CalculateH(countTrue  / (double)countTotal, countTrue  / (double)countTotal);
                }

                totalH += (double)((double)((double)countTotal / (double)set.GetDataCount()) * currentH);

                //Console.WriteLine("Key = {0}, Value = {1}, TRUE = {2}, FALSE = {3}, H = {4}", kvp.Key, kvp.Value, countTrue, countFalse, currentH);
            }

            return this.CalculateH(set) - totalH;
        }

        public TrainingSet GetExceptBranch(TrainingSet set, string attibrute) {

            List<TrainingSample> samples = new List<TrainingSample>(set.Samples);

            samples.RemoveAll(x => !x.Samples.Contains(attibrute));

            return new TrainingSet(set, samples);
        }


        public double CalculateH(TrainingSet set) {
            return this.CalculateH(set.GetP1(), set.GetP2());
        }

        public double CalculateH(double p1, double p2) {
            double P1Value = p1 * Math.Log(p1, 2);
            double P2Value = p2 * Math.Log(p2, 2);

            return -(P1Value + P2Value);
        }

        public string CalculateHead(TrainingSet set) {

            List<double> earningScales = new List<double>(set.Entries.Length);
            double highest = 0.0d;
            string highestName = string.Empty;

            for (int i = 0; i < set.Entries.Length; i++) {
                double scale = this.GetBranchEarningScale(set, i);
                if (i == 0) {
                    highest = scale;
                    highestName = set.Entries[0].Name;
                }

                if (highest < scale) {
                    highest = scale;
                    highestName = set.Entries[i].Name;
                }

                EntryResult result = new EntryResult(set.Entries[i].Name);
                result.EarningScale = scale;
                this.m_results.Add(result);
                earningScales.Add(scale);
            }

            return highestName;
        }

        public bool CalculateResult(TrainingSet set, string attibrute) {

            int index = GetEntryIDFor(set, attibrute);
            int totalEntries = set.Entries.Length;
            int totalOutCount = set.Entries[index].Values.Length;
            string[] entryValues = set.Entries[index].Values;
            string name = set.Entries[index].Name;
            double scale = this.GetBranchEarningScale(set, index);

            Dictionary<string, int> outCountsTrue = new Dictionary<string, int>(totalOutCount);
            Dictionary<string, int> outCountsFalse = new Dictionary<string, int>(totalOutCount);

            for (int i = 0; i < set.Samples.Count; i++) {
                string currentSample = set.Samples[i].Samples[index];

                bool including = entryValues.Any(s => s.Equals(currentSample, StringComparison.InvariantCultureIgnoreCase));

                if (including) {
                    if (set.Samples[i].Output) {
                        
                        if (!outCountsTrue.ContainsKey(currentSample)) {
                            outCountsTrue.Add(currentSample, 1);
                        } else {
                            outCountsTrue[currentSample]++;
                        }
                    } else {
                        if (!outCountsFalse.ContainsKey(currentSample)) {
                            outCountsFalse.Add(currentSample, 1);
                        } else {
                            outCountsFalse[currentSample]++;
                        }
                    }
                }
            }


            if (!outCountsTrue.ContainsKey(attibrute) && outCountsFalse.ContainsKey(attibrute)) {
                return false;
            } else if (outCountsTrue.ContainsKey(attibrute) && !outCountsFalse.ContainsKey(attibrute)) {
                return true;
            }


            //Console.WriteLine("================================");
            //Console.WriteLine($"NAME = {name}, SCALE = {scale}");
            //if (outCountsTrue.ContainsKey(attibrute)) {
            //    Console.WriteLine("TRUE COUNT : " + outCountsTrue[attibrute]);
            //}
            //if (outCountsFalse.ContainsKey(attibrute)) {
            //    Console.WriteLine("FALSE COUNT : " + outCountsFalse[attibrute]);
            //}
            //Console.WriteLine("================================");

            return false;
        }

        public void PrintEntryResults() {
            for (int i = 0; i < this.m_results.Count; i++) {
                Console.WriteLine("NAME = {0}, SCALE = {1}", this.m_results[i].SampleName, this.m_results[i].EarningScale);
            }
        }
        public void PrintTrainingSet(TrainingSet set) {
            for (int i = 0; i < set.Samples.Count; i++) {
                for (int j = 0; j < set.Samples[i].Samples.Length; j++) {
                    Console.WriteLine("NAME = {0}", set.Samples[i].Samples[j]);
                }
            }
        }

    }
}
