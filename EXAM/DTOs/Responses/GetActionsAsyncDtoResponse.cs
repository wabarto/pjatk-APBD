﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.DTOs.Responses
{
    public class GetActionsAsyncDtoResponse
    {
        public int IdAction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
