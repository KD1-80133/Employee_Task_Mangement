﻿namespace WebAPI.Model.TASKDTO
{
    public class TaskDTO
    {
        public int TaskId { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }


        public string TaskDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int WorkHours { get; set; }

        public string Status { get; set; }

        public override string ToString()
        {
            return TaskId + " " + ProjectId + " " + UserId + " " + TaskDescription + " " + StartDate
                + EndDate + " " + WorkHours + " " + Status;
        }
    }
}
