using System;
using System.Collections.Generic;
using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class StringUtilities
    {
        public static string GetPercentString(float f, bool includeSign = true) {
            return Mathf.RoundToInt(f * 100f) + (includeSign ? "%" : "");
        }

        public static string GetMonthName(int month) {
            switch (month) {
                default:
                case 0: return "January";
                case 1: return "February";
                case 2: return "March";
                case 3: return "April";
                case 4: return "May";
                case 5: return "June";
                case 6: return "July";
                case 7: return "August";
                case 8: return "September";
                case 9: return "October";
                case 10: return "November";
                case 11: return "December";
            }
        }

        public static string GetMonthNameShort(int month) {
            return GetMonthName(month).Substring(0, 3);
        }

        public static string GetTimeStringFromMilliSeconds(float time, bool hours = true, bool minutes = true, bool seconds = true,
            bool milliseconds = true)
        {
            var timeSpan = TimeSpan.FromMilliseconds(time);

            if (hours)
            {
                if (minutes)
                {
                    return seconds
                        ? timeSpan.ToString(milliseconds ? @"hh\:mm\:ss\:ff" : @"hh\:mm\:ss")
                        : timeSpan.ToString(@"hh\:mm");
                }
                
                return timeSpan.ToString(@"hh");
            }
            
            if (minutes)
            {
                return seconds
                    ? timeSpan.ToString(milliseconds ? @"mm\:ss\:ff" : @"mm\:ss")
                    : timeSpan.ToString(@"mm");
            }

            return seconds
            ? timeSpan.ToString(milliseconds ? @"ss\:ff" : @"ss")
            : timeSpan.ToString(@"ff");
        }
        
        // Get a random male name and optionally single letter surname
        public static string GetRandomName(bool withSurname = false) {
            var firstNameList = new List<string>
            {"Gabe","Cliff","Tim","Ron","Jon","John","Mike","Seth","Alex","Steve","Chris","Will","Bill","James","Jim",
                "Ahmed","Omar","Peter","Pierre","George","Lewis","Lewie","Adam","William","Ali","Eddie","Ed","Dick","Robert","Bob","Rob",
                "Neil","Tyson","Carl","Chris","Christopher","Jensen","Gordon","Morgan","Richard","Wen","Wei","Luke","Lucas","Noah","Ivan","Yusuf",
                "Ezio","Connor","Milan","Nathan","Victor","Harry","Ben","Charles","Charlie","Jack","Leo","Leonardo","Dylan","Steven","Jeff",
                "Alex","Mark","Leon","Oliver","Danny","Liam","Joe","Tom","Thomas","Bruce","Clark","Tyler","Jared","Brad","Jason"};

            if (!withSurname) {
                return firstNameList[UnityEngine.Random.Range(0, firstNameList.Count)];
            }

            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYWZ";
            return firstNameList[UnityEngine.Random.Range(0, firstNameList.Count)] + " " + alphabet[UnityEngine.Random.Range(0, alphabet.Length)] + ".";
        }
        
        public static string GetIdString(int chars) {
            const string alphabet = "0123456789abcdefghijklmnopqrstuvxywzABCDEFGHIJKLMNOPQRSTUVXYWZ";
            var ret = "";
            for (var i = 0; i < chars; i++) {
                ret += alphabet[UnityEngine.Random.Range(0, alphabet.Length)];
            }
            return ret;
        }
        
        // Return a number with milli dots, 1000000 -> 1.000.000
        public static string GetMilliDots(float n) {
            return GetMilliDots((long)n);
        }

        public static string GetMilliDots(long n) {
            var ret = n.ToString();
            for (var i = 1; i <= Mathf.Floor(ret.Length / 4); i++) {
                ret = ret.Substring(0, ret.Length - i * 3 - (i - 1)) + "." + ret.Substring(ret.Length - i * 3 - (i - 1));
            }
            return ret;
        }
        
        // Return with milli dots and dollar sign
        public static string GetDollars(float n) {
            return GetDollars((long)n);
        }
        
        public static string GetDollars(long n)
        {
            if (n < 0)
                return "-$" + GetMilliDots(Mathf.Abs(n));
            return "$" + GetMilliDots(n);
        }

    }
}
