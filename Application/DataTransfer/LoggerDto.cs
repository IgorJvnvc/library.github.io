﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DataTransfer
{
    public class LoggerDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UseCaseName { get; set; }
        public string Data { get; set; }
        public int ActorId { get; set; }
    }
}
