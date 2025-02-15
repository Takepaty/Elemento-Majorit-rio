﻿using System;
using System.Text.RegularExpressions;

public class Program
{
  public static void Main(String[] args)
  {
    int n = int.Parse(Console.ReadLine());

    int[] num = new int[n];

    for (int i = 0; i < n; i++)
    {
      num[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine(MajorityElement(num));

  }

  public static int MajorityElement(int[] nums)
  {
    int major = nums[0];
    int count = 1;
    for (int i = 1; i < nums.Length; i++)
    {
      if (count == 0)
      {
        major = nums[i];
        count++;
      }
      else
      {
        if (major == nums[i])
        {
          count++;
        }
        else
        {
          count--;
        }
      }
    }
    return major;
  }
}