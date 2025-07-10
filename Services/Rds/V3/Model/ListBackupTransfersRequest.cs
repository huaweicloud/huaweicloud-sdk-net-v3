using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBackupTransfersRequest 
    {
        /// <summary>
        /// 转储任务类型，默认为manual manual:手动转储任务 auto:自动转储任务
        /// </summary>
        /// <value>转储任务类型，默认为manual manual:手动转储任务 auto:自动转储任务</value>
        [JsonConverter(typeof(EnumClassConverter<TransferTypeEnum>))]
        public class TransferTypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly TransferTypeEnum MANUAL = new TransferTypeEnum("manual");

            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly TransferTypeEnum AUTO = new TransferTypeEnum("auto");

            private static readonly Dictionary<string, TransferTypeEnum> StaticFields =
            new Dictionary<string, TransferTypeEnum>()
            {
                { "manual", MANUAL },
                { "auto", AUTO },
            };

            private string _value;

            public TransferTypeEnum()
            {

            }

            public TransferTypeEnum(string value)
            {
                _value = value;
            }

            public static TransferTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TransferTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransferTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransferTypeEnum a, TransferTypeEnum b)
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

            public static bool operator !=(TransferTypeEnum a, TransferTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 查询记录数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        [JsonProperty("order_field", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderField { get; set; }

        /// <summary>
        /// 排序规则
        /// </summary>
        [SDKProperty("order_rule", IsQuery = true)]
        [JsonProperty("order_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderRule { get; set; }

        /// <summary>
        /// 筛选字段
        /// </summary>
        [SDKProperty("filter_field", IsQuery = true)]
        [JsonProperty("filter_field", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterField { get; set; }

        /// <summary>
        /// 筛选关键字
        /// </summary>
        [SDKProperty("filter_content", IsQuery = true)]
        [JsonProperty("filter_content", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterContent { get; set; }

        /// <summary>
        /// 开始时间戳
        /// </summary>
        [SDKProperty("begin_time", IsQuery = true)]
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 结束时间戳
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 转储任务类型，默认为manual manual:手动转储任务 auto:自动转储任务
        /// </summary>
        [SDKProperty("transfer_type", IsQuery = true)]
        [JsonProperty("transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public TransferTypeEnum TransferType { get; set; }
        /// <summary>
        /// 分页页码
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupTransfersRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderRule: ").Append(OrderRule).Append("\n");
            sb.Append("  filterField: ").Append(FilterField).Append("\n");
            sb.Append("  filterContent: ").Append(FilterContent).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  transferType: ").Append(TransferType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupTransfersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupTransfersRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrderField != input.OrderField || (this.OrderField != null && !this.OrderField.Equals(input.OrderField))) return false;
            if (this.OrderRule != input.OrderRule || (this.OrderRule != null && !this.OrderRule.Equals(input.OrderRule))) return false;
            if (this.FilterField != input.FilterField || (this.FilterField != null && !this.FilterField.Equals(input.FilterField))) return false;
            if (this.FilterContent != input.FilterContent || (this.FilterContent != null && !this.FilterContent.Equals(input.FilterContent))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.TransferType != input.TransferType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.OrderField != null) hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                if (this.OrderRule != null) hashCode = hashCode * 59 + this.OrderRule.GetHashCode();
                if (this.FilterField != null) hashCode = hashCode * 59 + this.FilterField.GetHashCode();
                if (this.FilterContent != null) hashCode = hashCode * 59 + this.FilterContent.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.TransferType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
