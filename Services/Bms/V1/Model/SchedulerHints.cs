using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// schedulerHints字段数据结构说明
    /// </summary>
    public class SchedulerHints 
    {
        /// <summary>
        /// Defines decBaremetal
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DecBaremetalEnum>))]
        public class DecBaremetalEnum
        {
            /// <summary>
            /// Enum SHARE for value: share
            /// </summary>
            public static readonly DecBaremetalEnum SHARE = new DecBaremetalEnum("share");

            /// <summary>
            /// Enum DEDICATE for value: dedicate
            /// </summary>
            public static readonly DecBaremetalEnum DEDICATE = new DecBaremetalEnum("dedicate");

            private static readonly Dictionary<string, DecBaremetalEnum> StaticFields =
            new Dictionary<string, DecBaremetalEnum>()
            {
                { "share", SHARE },
                { "dedicate", DEDICATE },
            };

            private string _value;

            public DecBaremetalEnum()
            {

            }

            public DecBaremetalEnum(string value)
            {
                _value = value;
            }

            public static DecBaremetalEnum FromValue(string value)
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

                if (this.Equals(obj as DecBaremetalEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DecBaremetalEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DecBaremetalEnum a, DecBaremetalEnum b)
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

            public static bool operator !=(DecBaremetalEnum a, DecBaremetalEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 是否在专属云中创建裸金属服务器，参数值为share或dedicate。约束：该值不传时默认为share。在专属云中创建裸金属服务器时，必须指定该字段为dedicate。
        /// </summary>
        [JsonProperty("dec_baremetal", NullValueHandling = NullValueHandling.Ignore)]
        public List<DecBaremetalEnum> DecBaremetal { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchedulerHints {\n");
            sb.Append("  decBaremetal: ").Append(DecBaremetal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchedulerHints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchedulerHints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DecBaremetal == input.DecBaremetal ||
                    this.DecBaremetal != null &&
                    input.DecBaremetal != null &&
                    this.DecBaremetal.SequenceEqual(input.DecBaremetal)
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
                if (this.DecBaremetal != null)
                    hashCode = hashCode * 59 + this.DecBaremetal.GetHashCode();
                return hashCode;
            }
        }
    }
}
