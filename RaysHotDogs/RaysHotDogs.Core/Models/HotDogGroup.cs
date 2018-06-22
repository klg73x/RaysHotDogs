﻿using System.Collections.Generic;

namespace RaysHotDogs.Core.Models
{
    public class HotDogGroup
    {
        public int HotDogGroupId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public  List<HotDog> HotDogs { get; set; }
    }
}
