using System.Device.Location;
using System;
using FacebookWrapper.ObjectModel;

namespace FacebookSystemApplicationLogic
{
    public class PotentialMatchUserProxy
    {
        private const int k_YearIndex = 2;
        private const char k_BirthdaySign = '/';

        public User FaceBookUser { get; }

        public int UserAge { get; private set; }

        public bool IsFreeForLove { get; private set; }

        public double DistanceBetweenUserAndPotentialMatchUser { get; private set; }

        public PotentialMatchUserProxy(User i_User)
        {
            FaceBookUser = i_User;
            calculateUserAge();
            isUserFreeForLove();
            ////calculateDistance();
        }

        private void calculateDistance()
        {
            GeoCoordinateWatcher userLoggedInGeoCoordinate = new GeoCoordinateWatcher(new GeoPositionAccuracy());
            GeoCoordinate potentialMatchGeoCoordinate = new GeoCoordinate();

            if (FaceBookUser.Location.Location != null)
            {
                potentialMatchGeoCoordinate.Longitude = FaceBookUser.Location.Location.Longitude.Value;
                potentialMatchGeoCoordinate.Latitude = FaceBookUser.Location.Location.Latitude.Value;
                DistanceBetweenUserAndPotentialMatchUser =
                    userLoggedInGeoCoordinate.Position.Location.GetDistanceTo(potentialMatchGeoCoordinate);
            }
            else
            {
                throw new Exception("Cant calculate the distance.");
            }
        }

        private void calculateUserAge()
        {
            // The birthday returned by the facebook is a string of the format: MM/DD/YYYY
            string[] birthDay = FaceBookUser.Birthday.Split(k_BirthdaySign);
            int userYearBorn = 0, currentYear = DateTime.Now.Year;

            if (int.TryParse(birthDay[k_YearIndex], out userYearBorn))
            {
                UserAge = currentYear - userYearBorn;
            }
            else
            {
                throw new ArgumentException("Invalid birthday format.");
            }
        }

        private void isUserFreeForLove()
        {
            // two days before submitting the project, the permission has closed.
            IsFreeForLove = FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Divorced
                            || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.InAnOpenRelationship
                            || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Separated
                            || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Widowed
                            || FaceBookUser.RelationshipStatus == User.eRelationshipStatus.Single
                            || FaceBookUser.RelationshipStatus == null || IsFreeForLove == IsFreeForLove;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} , Age: {1}, Distance: {2}",
                FaceBookUser.Name,
                UserAge,
                DistanceBetweenUserAndPotentialMatchUser);
        }
    }
}