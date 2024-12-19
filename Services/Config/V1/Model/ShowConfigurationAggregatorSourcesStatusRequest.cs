using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowConfigurationAggregatorSourcesStatusRequest 
    {
        /// <summary>
        /// 聚合帐号的状态。
        /// </summary>
        /// <value>聚合帐号的状态。</value>
        [JsonConverter(typeof(EnumClassConverter<UpdateStatusEnum>))]
        public class UpdateStatusEnum
        {
            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly UpdateStatusEnum SUCCEEDED = new UpdateStatusEnum("SUCCEEDED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly UpdateStatusEnum FAILED = new UpdateStatusEnum("FAILED");

            /// <summary>
            /// Enum OUTDATED for value: OUTDATED
            /// </summary>
            public static readonly UpdateStatusEnum OUTDATED = new UpdateStatusEnum("OUTDATED");

            private static readonly Dictionary<string, UpdateStatusEnum> StaticFields =
            new Dictionary<string, UpdateStatusEnum>()
            {
                { "SUCCEEDED", SUCCEEDED },
                { "FAILED", FAILED },
                { "OUTDATED", OUTDATED },
            };

            private string _value;

            public UpdateStatusEnum()
            {

            }

            public UpdateStatusEnum(string value)
            {
                _value = value;
            }

            public static UpdateStatusEnum FromValue(string value)
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

                if (this.Equals(obj as UpdateStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UpdateStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UpdateStatusEnum a, UpdateStatusEnum b)
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

            public static bool operator !=(UpdateStatusEnum a, UpdateStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源聚合器ID。
        /// </summary>
        [SDKProperty("aggregator_id", IsPath = true)]
        [JsonProperty("aggregator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// 聚合帐号的状态。
        /// </summary>
        [SDKProperty("update_status", IsQuery = true)]
        [JsonProperty("update_status", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateStatusEnum UpdateStatus { get; set; }
        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigurationAggregatorSourcesStatusRequest {\n");
            sb.Append("  aggregatorId: ").Append(AggregatorId).Append("\n");
            sb.Append("  updateStatus: ").Append(UpdateStatus).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigurationAggregatorSourcesStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigurationAggregatorSourcesStatusRequest input)
        {
            if (input == null) return false;
            if (this.AggregatorId != input.AggregatorId || (this.AggregatorId != null && !this.AggregatorId.Equals(input.AggregatorId))) return false;
            if (this.UpdateStatus != input.UpdateStatus) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.AggregatorId != null) hashCode = hashCode * 59 + this.AggregatorId.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateStatus.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
