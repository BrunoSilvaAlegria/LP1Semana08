using System;

namespace LootSort 
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        public bool CompareStrings(string s1, string s2) 
        {
            if (s1.Length != s2.Length) return false;
            for (int i = 0; i < s1.Length && i < s2.Length; i++)
            {
                if (s1[i] > s2[i] || s1[i] < s2[i]) return false;
            }
            return true;
        }   

        
        public int Compare(Loot l1, Loot l2)
        {
            int ord;
            if (true)
            {
                ord = l1.Kind.CompareTo(l2.Kind);
            }
            else
            {
                ord = l2.Kind.CompareTo(l1.Kind);
            }
            return ord;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}
