using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 诊断维度
    /// </summary>
    public class DiagnosisDimension 
    {
        /// <summary>
        /// 诊断维度名称
        /// </summary>
        /// <value>诊断维度名称</value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum NETWORK for value: network
            /// </summary>
            public static readonly NameEnum NETWORK = new NameEnum("network");

            /// <summary>
            /// Enum STORAGE for value: storage
            /// </summary>
            public static readonly NameEnum STORAGE = new NameEnum("storage");

            /// <summary>
            /// Enum LOAD for value: load
            /// </summary>
            public static readonly NameEnum LOAD = new NameEnum("load");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "network", NETWORK },
                { "storage", STORAGE },
                { "load", LOAD },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 诊断维度名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// 诊断结果为异常的诊断项总数
        /// </summary>
        [JsonProperty("abnormal_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalNum { get; set; }

        /// <summary>
        /// 诊断失败的诊断项总数
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// 诊断项列表
        /// </summary>
        [JsonProperty("diagnosis_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiagnosisItem> DiagnosisItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosisDimension {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  abnormalNum: ").Append(AbnormalNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  diagnosisItemList: ").Append(DiagnosisItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiagnosisDimension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiagnosisDimension input)
        {
            if (input == null) return false;
            if (this.Name != input.Name) return false;
            if (this.AbnormalNum != input.AbnormalNum || (this.AbnormalNum != null && !this.AbnormalNum.Equals(input.AbnormalNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.DiagnosisItemList != input.DiagnosisItemList || (this.DiagnosisItemList != null && input.DiagnosisItemList != null && !this.DiagnosisItemList.SequenceEqual(input.DiagnosisItemList))) return false;

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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AbnormalNum != null) hashCode = hashCode * 59 + this.AbnormalNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.DiagnosisItemList != null) hashCode = hashCode * 59 + this.DiagnosisItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
