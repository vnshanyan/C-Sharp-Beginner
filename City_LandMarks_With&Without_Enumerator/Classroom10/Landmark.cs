using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classroom10
{
    internal class Landmark
    {
        private Guid LandmarkId { get; set; }
        public string LandmarkName { get; set; }
        public string Description { get; set; }

        public Landmark(Guid landmarkId, string name, string description)
        {
            LandmarkId = landmarkId;
            LandmarkName = name;
            Description = description;
        }
    }
}
