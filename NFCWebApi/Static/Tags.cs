using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFCWebApi.Static {
    public class Tag {
        public string SerialId { get; set; }
        //public string AssignedEmployee { get; set; }
        public bool IsOccuppied { get; set; }

        //public Tag(string serialId, string employee, Position position) {
        //    this.SerialId = serialId;
        //    this.AssignedEmployee = employee;
        //    this.Position = position;
        //}
        public Tag(string serialId) {
            this.SerialId = serialId;
            this.IsOccuppied = false;
        }

        public void ToggleOccupation() {
            this.IsOccuppied = !this.IsOccuppied;
        }

        public override string ToString() {
            return $"{this.SerialId} is occupied: {this.IsOccuppied}";
            //return $"{this.AssignedEmployee} is checked in at {this.Position} with id {this.SerialId}";
        }
    }
}