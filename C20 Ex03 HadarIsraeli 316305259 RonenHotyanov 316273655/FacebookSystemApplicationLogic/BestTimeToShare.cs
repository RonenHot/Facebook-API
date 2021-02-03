using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    internal class BestTimeToShare
    {
        private const int k_HoursOfDay = 24;
        private const int k_ChangePeriodTimeOfDay = 4;
        private const int k_StartingMorningTimeOnDay = 6;
        private readonly Dictionary<eTimeOfDay, TimeInDay> r_GradeTheTimeInDay = new Dictionary<eTimeOfDay, TimeInDay>();
        private readonly Dictionary<DayOfWeek, int> r_GradeTheDays = new Dictionary<DayOfWeek, int>();

        public IFactorStrategy FactorStrategy { get; set; }

        private enum eTimeOfDay
        {
            Morning = 0, ////6am - 10pm
            Noon,        ////10pm - 2pm
            AfterNoon,   ////2pm - 6pm
            Evening,     ////6pm - 10pm
            Night,       ////10pm - 2am
            BeforeDawn   ////2am - 6am
        }

        private class TimeInDay
        {
            private eTimeOfDay TimeOfDay;

            public int TimeFrom { get; private set; }

            public int TimeTo { get; private set; }

            public int Grade { get; set; }

            public TimeInDay(eTimeOfDay i_TimeOfDay, int i_TimeFrom, int i_TimeTo)
            {
                TimeOfDay = i_TimeOfDay;
                TimeFrom = i_TimeFrom;
                TimeTo = i_TimeTo;
                Grade = 0;
            }
        }

        internal BestTimeToShare()
        {
            int index = k_StartingMorningTimeOnDay;

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                r_GradeTheDays.Add(day, 0);
            }

            foreach (eTimeOfDay timeOfDay in Enum.GetValues(typeof(eTimeOfDay)))
            {
                r_GradeTheTimeInDay.Add(timeOfDay, new TimeInDay(timeOfDay, index, index + k_ChangePeriodTimeOfDay));
                index += k_ChangePeriodTimeOfDay;
                if (index >= k_HoursOfDay)
                {
                    index = index % k_HoursOfDay;
                }
            }
        }

        private void analyzeTheBestTime(FacebookObjectCollection<Post> i_PostCollection)
        {
            int counterLikes = 0;
            int counterComments = 0;
            int gradeToAdd = 0;

            foreach (Post post in i_PostCollection)
            {
                counterComments = post.Comments.Count;
                counterLikes = post.LikedBy.Count;

                gradeToAdd = FactorStrategy.CurrentFactors(counterComments, counterLikes);
                if (post.CreatedTime.HasValue)
                {
                    addGradeToTimeInDay(post.CreatedTime.Value.Hour, gradeToAdd);
                    r_GradeTheDays[post.CreatedTime.Value.DayOfWeek] += gradeToAdd;
                }
            }
        }

        private void addGradeToTimeInDay(int i_Hour, int i_GradeToAdd)
        {
            bool isHourExistInTimeOfWeek = false;

            foreach (KeyValuePair<eTimeOfDay, TimeInDay> timeOfDay in r_GradeTheTimeInDay)
            {
                if (i_Hour > timeOfDay.Value.TimeFrom && i_Hour <= timeOfDay.Value.TimeTo)
                {
                    timeOfDay.Value.Grade += i_GradeToAdd;
                    isHourExistInTimeOfWeek = true;
                }
            }

            if (isHourExistInTimeOfWeek == false)
            {
                throw new ArgumentException("Not available hour.");
            }
        }

        private string bestDayToPost()
        {
            int maximumGradedDay = 0;
            string bestDay = string.Empty;

            foreach (KeyValuePair<DayOfWeek, int> dayInWeek in r_GradeTheDays)
            {
                if (dayInWeek.Value > maximumGradedDay)
                {
                    maximumGradedDay = dayInWeek.Value;
                    bestDay = dayInWeek.Key.ToString();
                }
            }

            if (maximumGradedDay == 0)
            {
                throw new ArgumentException("There is not enough data.");
            }

            return bestDay;
        }

        private string bestTimeInDayToPost()
        {
            int maximumGradedTimeInDay = 0;
            string bestTime = string.Empty;

            foreach (KeyValuePair<eTimeOfDay, TimeInDay> timeOfDay in r_GradeTheTimeInDay)
            {
                if (timeOfDay.Value.Grade > maximumGradedTimeInDay)
                {
                    maximumGradedTimeInDay = timeOfDay.Value.Grade;
                    bestTime = timeOfDay.Key.ToString();
                }
            }

            if (maximumGradedTimeInDay == 0)
            {
                throw new ArgumentException("There is not enough data.");
            }

            return bestTime;
        }

        internal void BestTimeToPost(FacebookObjectCollection<Post> i_PostCollection, out string o_BestDay, out string o_BestTimeOnDay)
        {
            analyzeTheBestTime(i_PostCollection);
            o_BestDay = bestDayToPost();
            o_BestTimeOnDay = bestTimeInDayToPost();
        }
    }
}
