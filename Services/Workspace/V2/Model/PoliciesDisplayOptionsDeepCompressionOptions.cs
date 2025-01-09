using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 深度压缩控制选项。
    /// </summary>
    public class PoliciesDisplayOptionsDeepCompressionOptions 
    {
        /// <summary>
        /// 深度压缩级别。取值为： 压缩级别0：Compression grade 0 压缩级别1：Compression grade 1 压缩级别2：Compression grade 2 压缩级别3：Compression grade 3 压缩级别4：Compression grade 4 压缩级别5：Compression grade 5 压缩级别6：Compression grade 6 压缩级别7：Compression grade 7 压缩级别8：Compression grade 8 压缩级别9：Compression grade 9
        /// </summary>
        /// <value>深度压缩级别。取值为： 压缩级别0：Compression grade 0 压缩级别1：Compression grade 1 压缩级别2：Compression grade 2 压缩级别3：Compression grade 3 压缩级别4：Compression grade 4 压缩级别5：Compression grade 5 压缩级别6：Compression grade 6 压缩级别7：Compression grade 7 压缩级别8：Compression grade 8 压缩级别9：Compression grade 9</value>
        [JsonConverter(typeof(EnumClassConverter<DeepCompressionLevelEnum>))]
        public class DeepCompressionLevelEnum
        {
            /// <summary>
            /// Enum COMPRESSION_GRADE_0 for value: Compression grade 0
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_0 = new DeepCompressionLevelEnum("Compression grade 0");

            /// <summary>
            /// Enum COMPRESSION_GRADE_1 for value: Compression grade 1
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_1 = new DeepCompressionLevelEnum("Compression grade 1");

            /// <summary>
            /// Enum COMPRESSION_GRADE_2 for value: Compression grade 2
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_2 = new DeepCompressionLevelEnum("Compression grade 2");

            /// <summary>
            /// Enum COMPRESSION_GRADE_3 for value: Compression grade 3
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_3 = new DeepCompressionLevelEnum("Compression grade 3");

            /// <summary>
            /// Enum COMPRESSION_GRADE_4 for value: Compression grade 4
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_4 = new DeepCompressionLevelEnum("Compression grade 4");

            /// <summary>
            /// Enum COMPRESSION_GRADE_5 for value: Compression grade 5
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_5 = new DeepCompressionLevelEnum("Compression grade 5");

            /// <summary>
            /// Enum COMPRESSION_GRADE_6 for value: Compression grade 6
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_6 = new DeepCompressionLevelEnum("Compression grade 6");

            /// <summary>
            /// Enum COMPRESSION_GRADE_7 for value: Compression grade 7
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_7 = new DeepCompressionLevelEnum("Compression grade 7");

            /// <summary>
            /// Enum COMPRESSION_GRADE_8 for value: Compression grade 8
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_8 = new DeepCompressionLevelEnum("Compression grade 8");

            /// <summary>
            /// Enum COMPRESSION_GRADE_9 for value: Compression grade 9
            /// </summary>
            public static readonly DeepCompressionLevelEnum COMPRESSION_GRADE_9 = new DeepCompressionLevelEnum("Compression grade 9");

            private static readonly Dictionary<string, DeepCompressionLevelEnum> StaticFields =
            new Dictionary<string, DeepCompressionLevelEnum>()
            {
                { "Compression grade 0", COMPRESSION_GRADE_0 },
                { "Compression grade 1", COMPRESSION_GRADE_1 },
                { "Compression grade 2", COMPRESSION_GRADE_2 },
                { "Compression grade 3", COMPRESSION_GRADE_3 },
                { "Compression grade 4", COMPRESSION_GRADE_4 },
                { "Compression grade 5", COMPRESSION_GRADE_5 },
                { "Compression grade 6", COMPRESSION_GRADE_6 },
                { "Compression grade 7", COMPRESSION_GRADE_7 },
                { "Compression grade 8", COMPRESSION_GRADE_8 },
                { "Compression grade 9", COMPRESSION_GRADE_9 },
            };

            private string _value;

            public DeepCompressionLevelEnum()
            {

            }

            public DeepCompressionLevelEnum(string value)
            {
                _value = value;
            }

            public static DeepCompressionLevelEnum FromValue(string value)
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

                if (this.Equals(obj as DeepCompressionLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeepCompressionLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeepCompressionLevelEnum a, DeepCompressionLevelEnum b)
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

            public static bool operator !=(DeepCompressionLevelEnum a, DeepCompressionLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 深度压缩级别。取值为： 压缩级别0：Compression grade 0 压缩级别1：Compression grade 1 压缩级别2：Compression grade 2 压缩级别3：Compression grade 3 压缩级别4：Compression grade 4 压缩级别5：Compression grade 5 压缩级别6：Compression grade 6 压缩级别7：Compression grade 7 压缩级别8：Compression grade 8 压缩级别9：Compression grade 9
        /// </summary>
        [JsonProperty("deep_compression_level", NullValueHandling = NullValueHandling.Ignore)]
        public DeepCompressionLevelEnum DeepCompressionLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayOptionsDeepCompressionOptions {\n");
            sb.Append("  deepCompressionLevel: ").Append(DeepCompressionLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayOptionsDeepCompressionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayOptionsDeepCompressionOptions input)
        {
            if (input == null) return false;
            if (this.DeepCompressionLevel != input.DeepCompressionLevel) return false;

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
                hashCode = hashCode * 59 + this.DeepCompressionLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
