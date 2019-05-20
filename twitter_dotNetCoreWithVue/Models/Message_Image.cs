﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace twitter_dotNetCoreWithVue.Models
{
    public class Message_Image
    {
        [Display(Name = "推特所含图片数量")]
        public int message_image_count { get; set; }

        [Display(Name = "图片所属推特的ID")]
        public int message_id { get; set; }

    }
}
