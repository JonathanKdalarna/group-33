using System;

namespace GIK299_L4_Labbgrupp123
{
    internal class Person
    {
        internal Gender TheGender { get; set; }
        internal Hair HairType { get; set; }
        internal string EyeColor { get; set; }
        internal DateTime BirthDay { get; set; }
        internal Names Name { get; set; }

        internal Person(Names name, Gender gender, Hair hair, string eye, DateTime birthDay)
        {
            TheGender = gender;
            HairType = hair;
            EyeColor = eye;
            BirthDay = birthDay;
            Name = name;
        }

        public override string ToString()
        {
            return 
                $"Name: {Name.FirstName} {Name.LastName} " +
                $"Gender: {TheGender}" +
                $"\nBirthday:{BirthDay: yyyy/MM/dd}" +
                $"\nHair length: {HairType.HairLength} cm and Hair color: {HairType.HairColor}" +
                $"\nEye color: {EyeColor}";
        }
    }
}
