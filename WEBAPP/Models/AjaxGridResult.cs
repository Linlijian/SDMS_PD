﻿namespace WEBAPP.Models
{
    public class AjaxGridResult : BaseAjaxResult
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public object data { get; set; }
        public string error { get; set; }
    }
}