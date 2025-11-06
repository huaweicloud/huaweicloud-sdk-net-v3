using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PromLimits 
    {
        /// <summary>
        /// 指标存储时长，只支持 15天，30天，60天 ，90天
        /// </summary>
        /// <value>指标存储时长，只支持 15天，30天，60天 ，90天</value>
        [JsonConverter(typeof(EnumClassConverter<CompactorBlocksRetentionPeriodEnum>))]
        public class CompactorBlocksRetentionPeriodEnum
        {
            /// <summary>
            /// Enum _360H_ for value: \"360h\"
            /// </summary>
            public static readonly CompactorBlocksRetentionPeriodEnum _360H_ = new CompactorBlocksRetentionPeriodEnum("\"360h\"");

            /// <summary>
            /// Enum _720H_ for value:  \"720h\"
            /// </summary>
            public static readonly CompactorBlocksRetentionPeriodEnum _720H_ = new CompactorBlocksRetentionPeriodEnum(" \"720h\"");

            /// <summary>
            /// Enum _1440H_ for value:  \"1440h\"
            /// </summary>
            public static readonly CompactorBlocksRetentionPeriodEnum _1440H_ = new CompactorBlocksRetentionPeriodEnum(" \"1440h\"");

            /// <summary>
            /// Enum _2160H_ for value:  \"2160h\"
            /// </summary>
            public static readonly CompactorBlocksRetentionPeriodEnum _2160H_ = new CompactorBlocksRetentionPeriodEnum(" \"2160h\"");

            private static readonly Dictionary<string, CompactorBlocksRetentionPeriodEnum> StaticFields =
            new Dictionary<string, CompactorBlocksRetentionPeriodEnum>()
            {
                { "\"360h\"", _360H_ },
                { " \"720h\"", _720H_ },
                { " \"1440h\"", _1440H_ },
                { " \"2160h\"", _2160H_ },
            };

            private string _value;

            public CompactorBlocksRetentionPeriodEnum()
            {

            }

            public CompactorBlocksRetentionPeriodEnum(string value)
            {
                _value = value;
            }

            public static CompactorBlocksRetentionPeriodEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CompactorBlocksRetentionPeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompactorBlocksRetentionPeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompactorBlocksRetentionPeriodEnum a, CompactorBlocksRetentionPeriodEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CompactorBlocksRetentionPeriodEnum a, CompactorBlocksRetentionPeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指标存储时长，只支持 15天，30天，60天 ，90天
        /// </summary>
        [JsonProperty("compactor_blocks_retention_period", NullValueHandling = NullValueHandling.Ignore)]
        public CompactorBlocksRetentionPeriodEnum CompactorBlocksRetentionPeriod { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromLimits {\n");
            sb.Append("  compactorBlocksRetentionPeriod: ").Append(CompactorBlocksRetentionPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromLimits);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PromLimits input)
        {
            if (input == null) return false;
            if (this.CompactorBlocksRetentionPeriod != input.CompactorBlocksRetentionPeriod) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                hashCode = hashCode * 59 + this.CompactorBlocksRetentionPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
