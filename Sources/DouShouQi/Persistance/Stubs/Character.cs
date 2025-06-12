/***************************************************************************
* Character.cs
* -------------------------------------------------------------------------
* Project       : DouShouQi Mythology
* Author        : ANGIA Shreya
* Date          : 29/05/2025
* Description   : Creates all the characters with its information             
* -------------------------------------------------------------------------
***************************************************************************/


using System.Collections.Generic;

namespace Stubs
{
    public class Character
    {
        public string? Name { get; set; }
        public string? Characteristic { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        /// <summary>
        /// Creating all the gods and godnesses with their information
        /// </summary>
        /// <returns>List<Characer></returns> 
        public static List<Character> GetAll() 
        {
            return new List<Character>
            {
               
                new Character
                {
                    Name = "Zeus - Jupiter",
                    Characteristic = "Sky",
                    Description = "Zeus was the most powerful of the Greek gods and goddesses. As god of the sky and king of Olympus, his temper affected the weather. Zeus also rules over all other gods and goddesses, so he was worshipped in most ancient Greek homes through altars, shrines and daily offerings. Zeus had the power to change his shape and he was also married to the queen of the gods, Hera.",
                    Image = "zeus_presentation.jpg"
                },
                new Character
                {
                    Name = "Poseidon - Neptune",
                    Characteristic = "Sea",
                    Description = "As god of the sea and brother of Zeus, Poseidon was one of the most powerful Greek gods. Similar to Zeus, Poseidon's temper controlled the seas, so sailors would pray to Poseidon before voyages to ensure safe passage.",
                    Image = "poseidon_presentation.jpg"
                },

                 new Character
                {
                    Name = "Hades - Pluto",
                    Characteristic = "Underworld",
                    Description = "Hades, brother of Zeus and Poseidon, is the god of the underworld and ruler of the dead. He is known for his strict but fair rule over the realm of the deceased and is often associated with wealth and the riches found underground.",
                    Image = "hades_presentation.jpg"
                },

                   new Character
                {
                    Name = "Athena - Minerva",
                    Characteristic = "War & Wisdom",
                    Description = "The daughter of Zeus, Athena was the goddess of battle strategy and wisdom, with her sacred symbols being the owl and the olive tree. Athena did not have a mother, being born directly from Zeus' head wearing a suit of armour! As goddess of battle strategy, she is the female counterpart of Ares. Athena is the patron god of the Greek city, Athens.",
                    Image = "athena_presentation.jpg"
                },

                    new Character
                {
                    Name = "Hephaestus - Vulcan",
                    Characteristic = "Fire & Metal",
                    Description = "The son of Zeus and Hera, Hephaestus was the Greek god of fire, metal working, sculpture. Hephaestus was associated with craftsmen and blacksmiths, and was married to the goddess, Aphrodite. Unlike other Greek gods and goddesses, Hephaestus was physically flawed, being known as “the lame one”, due to being thrown from Mount Olympus by Hera. He is depicted with a hammer and an anvil.",
                    Image = "hephaestus_presentation.jpg"
                },

                 new Character
                {
                    Name = "Hermes - Mercure",
                    Characteristic = "Messenger",
                    Description = "The youngest son of Zeus, Hermes became the messenger of the gods due to his speed and trustworthiness. Wearing winged shoes, Hermes could fly and travel quickly. Hermes was the protector of travellers and merchants. He is credited with the invention of boxing and gymnastics.",
                    Image = "hermes_presentation.jpg"
                },

                new Character
                {
                    Name = "Aphrodite - Venus",
                    Characteristic = "Love & Beauty",
                    Description = "Aphrodite was largely worshipped as goddess of love and beauty in many of the city-states that made up Ancient Greece. As goddess of love and fertility, Aphrodite's symbols were doves, roses, swans, and sparrows. Aphrodite was believed to be either the daughter of Zeus, or risen from the sea upon a shell.",
                    Image = "aphrodite_presentation.jpg"
                },
               
               
                new Character 
                {
                    Name = "Heracles - Hercules",
                    Characteristic = "Strength",
                    Description = "Hercules is the Roman name given to the hero Heracles from Greek mythology. He is the illegitimate son of a mortal woman and Zeus, the king of all Olympian gods, and is renowned for his extraordinary strength. He also was a brutal character who murdered his family and many others over his lifetime.",
                    Image = "heracles_presentation.jpg"
                }
            };
        }
    }
}
