using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateLogStreamParams 
    {
        /// <summary>
        /// 日志存储时间（天）。   该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。
        /// </summary>
        /// <value>日志存储时间（天）。   该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。</value>
        [JsonConverter(typeof(EnumClassConverter<TtlInDaysEnum>))]
        public class TtlInDaysEnum
        {
            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly TtlInDaysEnum NUMBER_7 = new TtlInDaysEnum(7);

            private static readonly Dictionary<int?, TtlInDaysEnum> StaticFields =
            new Dictionary<int?, TtlInDaysEnum>()
            {
                { 7, NUMBER_7 },
            };

            private int? _value;

            public TtlInDaysEnum()
            {

            }

            public TtlInDaysEnum(int? value)
            {
                _value = value;
            }

            public static TtlInDaysEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as TtlInDaysEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TtlInDaysEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TtlInDaysEnum a, TtlInDaysEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TtlInDaysEnum a, TtlInDaysEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 日志存储时间（天）。   该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public TtlInDaysEnum TtlInDays { get; set; }
        /// <summary>
        /// 标签字段信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsBody> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLogStreamParams {\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLogStreamParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLogStreamParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TtlInDays == input.TtlInDays ||
                    (this.TtlInDays != null &&
                    this.TtlInDays.Equals(input.TtlInDays))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TtlInDays != null)
                    hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
