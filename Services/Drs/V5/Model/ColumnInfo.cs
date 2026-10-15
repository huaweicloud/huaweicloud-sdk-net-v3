using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 列信息
    /// </summary>
    public class ColumnInfo 
    {
        /// <summary>
        /// 列的脱敏算法类型（主键和唯一键不支持）。取值： - NAME ：姓名中间遮盖。 - PHONE ：电话中间遮盖。 - IDENTITY_CARD ：证件号码中间遮盖。  - BANK_CARD ：银行卡号中间遮盖。 - EMAIL ：邮箱前缀首字母后遮盖。 - ADDRESS ：地址后缀遮盖。  - DATE ：仅保留年代日期替换为1月1日。  - NUMERIC ：数字变0。 - SECRET_CONTENT ：大段文本全替换。
        /// </summary>
        /// <value>列的脱敏算法类型（主键和唯一键不支持）。取值： - NAME ：姓名中间遮盖。 - PHONE ：电话中间遮盖。 - IDENTITY_CARD ：证件号码中间遮盖。  - BANK_CARD ：银行卡号中间遮盖。 - EMAIL ：邮箱前缀首字母后遮盖。 - ADDRESS ：地址后缀遮盖。  - DATE ：仅保留年代日期替换为1月1日。  - NUMERIC ：数字变0。 - SECRET_CONTENT ：大段文本全替换。</value>
        [JsonConverter(typeof(EnumClassConverter<DesensitizationAlgorithmEnum>))]
        public class DesensitizationAlgorithmEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum NAME = new DesensitizationAlgorithmEnum("name");

            /// <summary>
            /// Enum PHONE for value: phone
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum PHONE = new DesensitizationAlgorithmEnum("phone");

            /// <summary>
            /// Enum IDENTITY_CARD for value: identity_card
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum IDENTITY_CARD = new DesensitizationAlgorithmEnum("identity_card");

            /// <summary>
            /// Enum BANK_CARD for value: bank_card
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum BANK_CARD = new DesensitizationAlgorithmEnum("bank_card");

            /// <summary>
            /// Enum EMAIL for value: email
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum EMAIL = new DesensitizationAlgorithmEnum("email");

            /// <summary>
            /// Enum ADDRESS for value: address
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum ADDRESS = new DesensitizationAlgorithmEnum("address");

            /// <summary>
            /// Enum DATE for value: date
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum DATE = new DesensitizationAlgorithmEnum("date");

            /// <summary>
            /// Enum NUMERIC for value: numeric
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum NUMERIC = new DesensitizationAlgorithmEnum("numeric");

            /// <summary>
            /// Enum SECRET_CONTENT for value: secret_content
            /// </summary>
            public static readonly DesensitizationAlgorithmEnum SECRET_CONTENT = new DesensitizationAlgorithmEnum("secret_content");

            private static readonly Dictionary<string, DesensitizationAlgorithmEnum> StaticFields =
            new Dictionary<string, DesensitizationAlgorithmEnum>()
            {
                { "name", NAME },
                { "phone", PHONE },
                { "identity_card", IDENTITY_CARD },
                { "bank_card", BANK_CARD },
                { "email", EMAIL },
                { "address", ADDRESS },
                { "date", DATE },
                { "numeric", NUMERIC },
                { "secret_content", SECRET_CONTENT },
            };

            private string _value;

            public DesensitizationAlgorithmEnum()
            {

            }

            public DesensitizationAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static DesensitizationAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as DesensitizationAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DesensitizationAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DesensitizationAlgorithmEnum a, DesensitizationAlgorithmEnum b)
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

            public static bool operator !=(DesensitizationAlgorithmEnum a, DesensitizationAlgorithmEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 列名
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 列类型
        /// </summary>
        [JsonProperty("column_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnType { get; set; }

        /// <summary>
        /// 列的键类型。
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        /// <summary>
        /// 列映射后的名称
        /// </summary>
        [JsonProperty("column_mapped_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnMappedName { get; set; }

        /// <summary>
        /// 该列是否过滤
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status { get; set; }

        /// <summary>
        /// 该列是否partitionKey
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partition { get; set; }

        /// <summary>
        /// 列的脱敏算法类型（主键和唯一键不支持）。取值： - NAME ：姓名中间遮盖。 - PHONE ：电话中间遮盖。 - IDENTITY_CARD ：证件号码中间遮盖。  - BANK_CARD ：银行卡号中间遮盖。 - EMAIL ：邮箱前缀首字母后遮盖。 - ADDRESS ：地址后缀遮盖。  - DATE ：仅保留年代日期替换为1月1日。  - NUMERIC ：数字变0。 - SECRET_CONTENT ：大段文本全替换。
        /// </summary>
        [JsonProperty("desensitization_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public DesensitizationAlgorithmEnum DesensitizationAlgorithm { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnInfo {\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  columnType: ").Append(ColumnType).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  columnMappedName: ").Append(ColumnMappedName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  desensitizationAlgorithm: ").Append(DesensitizationAlgorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnInfo input)
        {
            if (input == null) return false;
            if (this.ColumnName != input.ColumnName || (this.ColumnName != null && !this.ColumnName.Equals(input.ColumnName))) return false;
            if (this.ColumnType != input.ColumnType || (this.ColumnType != null && !this.ColumnType.Equals(input.ColumnType))) return false;
            if (this.KeyType != input.KeyType || (this.KeyType != null && !this.KeyType.Equals(input.KeyType))) return false;
            if (this.ColumnMappedName != input.ColumnMappedName || (this.ColumnMappedName != null && !this.ColumnMappedName.Equals(input.ColumnMappedName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.DesensitizationAlgorithm != input.DesensitizationAlgorithm) return false;

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
                if (this.ColumnName != null) hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.ColumnType != null) hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.KeyType != null) hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.ColumnMappedName != null) hashCode = hashCode * 59 + this.ColumnMappedName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                hashCode = hashCode * 59 + this.DesensitizationAlgorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
