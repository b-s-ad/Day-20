﻿using System;
using System.Text;
using System.Collections.Generic;

namespace MoodAnalyser  // 3.1 Null // 3.2 Empty
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        { }
        public MoodAnalyser(string messgage)
        {
            this.message = messgage;

        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }  
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }

        }

    }

