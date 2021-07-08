using System;

namespace Epam.TL.OnlinePhoto.FlashPictures.Entites
{
    public class Image
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid CreationId { get; set; }

        public string ContentType { get; set; }

        public byte[] Date { get; set; }
    }
}
