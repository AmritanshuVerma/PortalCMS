﻿using Portal.CMS.Entities.Entities.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Web.ViewModels.Shared
{
    public class PaginationViewModel
    {
        public string PaginationType { get; set; }

        public IEnumerable<Image> ImageList { get; set; }

        public double PageCount
        {
            get
            {
                return Math.Ceiling(Convert.ToDouble(ImageList.Count()) / 8);
            }
        }
    }
}