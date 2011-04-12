using System;

namespace WatchMeConsume.Models
{
    public class ConsumedItem
    {
        /// <summary>
        /// The Id of the Consumed Item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Id of the Consumer of the Consumed Item
        /// </summary>
        public int ConsumerId { get; set; }

        /// <summary>
        /// The Name of the Consumed Item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Description of the Consumed Item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Quantity of the Consumed Item
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The Location of the Consumed Item
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The Date of the Consumed Item
        /// </summary>
        public DateTime Date { get; set; }
    }
}