using System;
using System.Collections.Generic;

public class Stat {		
    
        public static string stat(string strg) {
            if (string.IsNullOrEmpty(strg))
              return "";

            string[] resArr = strg.Split(',');
            List<int> results = new List<int>();
            
            foreach (string res in resArr) {
              results.Add(toSeconds(res));
            }
            
            results.Sort();
            int range = results[results.Count - 1] - results[0];
            int avg = 0;
            foreach (var res in results) {
              avg += res;
            }
            avg = avg / results.Count;
            int median = findMedian(results, results.Count);

            return string.Format("Range: {0} Average: {1} Median: {2}", formatSeconds(range), formatSeconds(avg), formatSeconds(median));
        }
        
        public static int findMedian(List<int> arr, int n) { 
            if (n % 2 != 0) 
              return arr[n / 2]; 
          
            return (arr[(n - 1) / 2] + arr[n / 2]) / 2; 
        } 
        
        public static int toSeconds(string res) {
          List<int> time = new List<int>();
          string[] timeStr = res.Split('|');
          foreach(var str in timeStr) {
            time.Add(Int32.Parse(str));
          }
          return (time[0]*3600) + (time[1]*60) + time[2];
        }
        
        public static string formatSeconds(int seconds) {
          int second = seconds % 60;
          int minute = ((seconds - second)/60) % 60;
          int hour = (seconds - second - 60 * minute) / 3600;
          return string.Format("{0:00}|{1:00}|{2:00}", hour, minute, second);
        }
    }