﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics {
    public static class Probability {

        public static float arithmeticStandartDeviation(IEnumerable<float> values) {
            return (float)System.Math.Sqrt((double)Mathematics.Probability.arithmeticVariance(values));
        }
        public static float arithmeticVariance(IEnumerable<float> values) {
            var mean = arithmeticMean(values);
            var squareMean = arithmeticMean(square(values));
            return squareMean - mean * mean;
        }
        public static IEnumerable<float> square(IEnumerable<float> values) {
            foreach (var item in values) {
                yield return item * item;
            }
        }

        public static float arithmeticMean(IEnumerable<float> values) {
            float sum = 0;
            int count = 0;
            foreach (var item in values) {
                count++;
                sum += item;
            }
            return sum / count;
        }
        public static float median(IList<float> values) {
            var count = values.Count;
            if (count % 2 == 0) {
                var halIndex = count / 2;
                return (values[halIndex] + values[halIndex - 1]) * 0.5f;
            }
            else {
                return values[count / 2];
            }

        }
        public static IEnumerable<float> sum(IEnumerable<float> vector1, IEnumerable<float> vector2) {
            var e1 = vector1.GetEnumerator();
            foreach (var item in vector2) {
                e1.MoveNext();
                yield return e1.Current + item;
            }
        }
        public static IList<IList<T>> allCombinations<T>(IList<T> collection) {
            int count = collection.Count;
            List<IList<T>> combinations = new List<IList<T>>();
            var cl = new List<T>();
            for (int combinationCount = 1; combinationCount <= count; combinationCount++) {
                allNCombinations(collection, combinationCount, combinations, cl, 0);
            }
            return combinations;
        }
        public static IList<IList<T>> allNCombinations<T>(IList<T> collection, int n) {
            List<IList<T>> combinations = new List<IList<T>>();
            allNCombinations(collection, n, combinations, new List<T>(), 0);
            return combinations;
        }
        private static void allNCombinations<T>(IList<T> collection, int n, List<IList<T>> results, List<T> currentList, int startIndex) {
            if (n == 0) {
                results.Add(new List<T>(currentList));
            }
            else {
                var count = collection.Count - n + 1;
                for (int i = startIndex; i < count; i++) {
                    currentList.Add(collection[i]);

                    allNCombinations(collection, n - 1, results, currentList, i + 1);

                    currentList.RemoveAt(currentList.Count - 1);
                }
            }
        }
    }
}