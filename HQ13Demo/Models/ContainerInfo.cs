using System;

namespace HQ13Demo.Models
{
    public class ContainerInfo
    {
        private string _containerNo;
        private string _iso;

        public string ContainerNo
        {
            get => _containerNo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Số container không được để trống.");
                _containerNo = value.Trim().ToUpperInvariant();
            }
        }

        public string Iso
        {
            get => _iso;
            set => _iso = (value ?? string.Empty).Trim().ToUpperInvariant();
        }

        public string SealNo { get; set; }
        public string OperatorCode { get; set; }
        public bool IsCustomsCleared { get; private set; }
        public DateTime? ClearedDate { get; private set; }

        public ContainerInfo(string containerNo, string iso = "22G1", string sealNo = "SNP001", string operatorCode = "ONE")
        {
            ContainerNo = containerNo;
            Iso = iso;
            SealNo = sealNo;
            OperatorCode = operatorCode;
            IsCustomsCleared = false;
        }
        public void MarkAsCleared(DateTime clearedDate)
        {
            IsCustomsCleared = true;
            ClearedDate = clearedDate;
        }
    }
}
