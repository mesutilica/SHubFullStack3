namespace Konu14InterfacesArayuzler
{
    internal interface ISinifGereksinimleri // bu interface her class ta bulunması gereken zorunlu özellikleri içeriyor
    {
        public int Id { get; set; } // nesnenin benzersiz kimlik değeri
        public DateTime CreateDate { get; set; } // nesnenin oluşma zamanını tutacak özellik
        public DateTime UpdateDate { get; set; } // nesnenin son güncellenme zamanını tutacak özellik
        public bool IsActive { get; set; } // nesnenin aktiflik durumunu tutacak olan özellik
    }
}
