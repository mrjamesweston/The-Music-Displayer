﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace SMD
{
    [XmlRoot("PlayerList")]
    public class PlayerList
    {
        [XmlElement("Player")]
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Type")]
        public MusicPlayers Type { get; set; }

        [XmlElement("Enabled")]
        public bool Enabled { get; set; }
    }
}
