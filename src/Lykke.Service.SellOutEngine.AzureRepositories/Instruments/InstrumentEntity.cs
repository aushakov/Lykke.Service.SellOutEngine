using JetBrains.Annotations;
using Lykke.AzureStorage.Tables;
using Lykke.AzureStorage.Tables.Entity.Annotation;
using Lykke.AzureStorage.Tables.Entity.ValueTypesMerging;
using Lykke.Service.SellOutEngine.Domain;

namespace Lykke.Service.SellOutEngine.AzureRepositories.Instruments
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    [ValueTypeMergingStrategy(ValueTypeMergingStrategy.UpdateIfDirty)]
    public class InstrumentEntity : AzureTableEntity
    {
        private decimal _markup;
        private int _levels;
        private decimal _minSpread;
        private decimal _maxSpread;
        private InstrumentMode _mode;
        private bool _isApproved;

        public InstrumentEntity()
        {
        }

        public InstrumentEntity(string partitionKey, string rowKey)
        {
            PartitionKey = partitionKey;
            RowKey = rowKey;
        }

        public string AssetPairId { get; set; }

        public string QuoteSource { get; set; }

        public decimal Markup
        {
            get => _markup;
            set
            {
                if (_markup != value)
                {
                    _markup = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }

        public int Levels
        {
            get => _levels;
            set
            {
                if (_levels != value)
                {
                    _levels = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }

        public decimal MinSpread
        {
            get => _minSpread;
            set
            {
                if (_minSpread != value)
                {
                    _minSpread = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }

        public decimal MaxSpread
        {
            get => _maxSpread;
            set
            {
                if (_maxSpread != value)
                {
                    _maxSpread = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }

        public InstrumentMode Mode
        {
            get => _mode;
            set
            {
                if (_mode != value)
                {
                    _mode = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }

        public bool IsApproved
        {
            get => _isApproved;
            set
            {
                if (_isApproved != value)
                {
                    _isApproved = value;
                    MarkValueTypePropertyAsDirty();
                }
            }
        }
    }
}
