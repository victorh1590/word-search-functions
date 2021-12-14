using System.Security.AccessControl;
using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

WriteLine("Hello, World!");

SortedDictionary<int, string> DescendentDiagonal(string input) 
{
    List<string> lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList<string>();
    int numColumns = lines.First().Length;
    int numLines = lines.Count();

    SortedDictionary<int, string> result = new();
    for(int i = 0; i < numLines; i++) {
      for (int j = 0; j < numColumns; j++) {
        if (result.ContainsKey(j-i)) result[j-i] += lines[i][j]; 
        else result.Add(j-i, lines[i][j].ToString());
      }
    }

    return result;
}

string grid =
            "jefblpepre\n" +
            "camdcimgtc\n" +
            "oivokprjsm\n" +
            "pbwasqroua\n";
            
            // "rixilelhrs\n" +
            // "wolcqlirpc\n" +
            // "screeaumgr\n" +
            // "alxhpburyi\n" +
            // "jalaycalmp\n" +
            // "clojurermt";


var result = DescendentDiagonal(grid);

foreach(var x in result) {
  WriteLine($"{x.Key} => {x.Value}");
}