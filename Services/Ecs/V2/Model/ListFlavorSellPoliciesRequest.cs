using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFlavorSellPoliciesRequest 
    {
        /// <summary>
        /// 云服务器的系统规格销售状态。  取值范围：  - available：正常售卖 - sellout：售罄
        /// </summary>
        /// <value>云服务器的系统规格销售状态。  取值范围：  - available：正常售卖 - sellout：售罄</value>
        [JsonConverter(typeof(EnumClassConverter<SellStatusEnum>))]
        public class SellStatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly SellStatusEnum AVAILABLE = new SellStatusEnum("available");

            /// <summary>
            /// Enum SELLOUT for value: sellout
            /// </summary>
            public static readonly SellStatusEnum SELLOUT = new SellStatusEnum("sellout");

            private static readonly Dictionary<string, SellStatusEnum> StaticFields =
            new Dictionary<string, SellStatusEnum>()
            {
                { "available", AVAILABLE },
                { "sellout", SELLOUT },
            };

            private string _value;

            public SellStatusEnum()
            {

            }

            public SellStatusEnum(string value)
            {
                _value = value;
            }

            public static SellStatusEnum FromValue(string value)
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

                if (this.Equals(obj as SellStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SellStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SellStatusEnum a, SellStatusEnum b)
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

            public static bool operator !=(SellStatusEnum a, SellStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 计费模式。  key的取值范围：  - postPaid：按需计费实例。 - prePaid：包年/包月计费实例。 - spot：竞价实例。 - ri：预留实例。
        /// </summary>
        /// <value>计费模式。  key的取值范围：  - postPaid：按需计费实例。 - prePaid：包年/包月计费实例。 - spot：竞价实例。 - ri：预留实例。</value>
        [JsonConverter(typeof(EnumClassConverter<SellModeEnum>))]
        public class SellModeEnum
        {
            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly SellModeEnum POSTPAID = new SellModeEnum("postPaid");

            /// <summary>
            /// Enum PREPAID for value: prePaid
            /// </summary>
            public static readonly SellModeEnum PREPAID = new SellModeEnum("prePaid");

            /// <summary>
            /// Enum SPOT for value: spot
            /// </summary>
            public static readonly SellModeEnum SPOT = new SellModeEnum("spot");

            /// <summary>
            /// Enum RI for value: ri
            /// </summary>
            public static readonly SellModeEnum RI = new SellModeEnum("ri");

            private static readonly Dictionary<string, SellModeEnum> StaticFields =
            new Dictionary<string, SellModeEnum>()
            {
                { "postPaid", POSTPAID },
                { "prePaid", PREPAID },
                { "spot", SPOT },
                { "ri", RI },
            };

            private string _value;

            public SellModeEnum()
            {

            }

            public SellModeEnum(string value)
            {
                _value = value;
            }

            public static SellModeEnum FromValue(string value)
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

                if (this.Equals(obj as SellModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SellModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SellModeEnum a, SellModeEnum b)
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

            public static bool operator !=(SellModeEnum a, SellModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 中断策略。  取值范围：  - immediate：立即释放 - delay：延迟释放
        /// </summary>
        /// <value>中断策略。  取值范围：  - immediate：立即释放 - delay：延迟释放</value>
        [JsonConverter(typeof(EnumClassConverter<InterruptionPolicyEnum>))]
        public class InterruptionPolicyEnum
        {
            /// <summary>
            /// Enum IMMEDIATE for value: immediate
            /// </summary>
            public static readonly InterruptionPolicyEnum IMMEDIATE = new InterruptionPolicyEnum("immediate");

            /// <summary>
            /// Enum DELAY for value: delay
            /// </summary>
            public static readonly InterruptionPolicyEnum DELAY = new InterruptionPolicyEnum("delay");

            private static readonly Dictionary<string, InterruptionPolicyEnum> StaticFields =
            new Dictionary<string, InterruptionPolicyEnum>()
            {
                { "immediate", IMMEDIATE },
                { "delay", DELAY },
            };

            private string _value;

            public InterruptionPolicyEnum()
            {

            }

            public InterruptionPolicyEnum(string value)
            {
                _value = value;
            }

            public static InterruptionPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as InterruptionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InterruptionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
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

            public static bool operator !=(InterruptionPolicyEnum a, InterruptionPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器的系统规格的ID
        /// </summary>
        [SDKProperty("flavor_id", IsQuery = true)]
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 云服务器的系统规格销售状态。  取值范围：  - available：正常售卖 - sellout：售罄
        /// </summary>
        [SDKProperty("sell_status", IsQuery = true)]
        [JsonProperty("sell_status", NullValueHandling = NullValueHandling.Ignore)]
        public SellStatusEnum SellStatus { get; set; }
        /// <summary>
        /// 计费模式。  key的取值范围：  - postPaid：按需计费实例。 - prePaid：包年/包月计费实例。 - spot：竞价实例。 - ri：预留实例。
        /// </summary>
        [SDKProperty("sell_mode", IsQuery = true)]
        [JsonProperty("sell_mode", NullValueHandling = NullValueHandling.Ignore)]
        public SellModeEnum SellMode { get; set; }
        /// <summary>
        /// 可用区，需要指定可用区（AZ）
        /// </summary>
        [SDKProperty("availability_zone_id", IsQuery = true)]
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 查询竞价实例时长大于设置值的策略
        /// </summary>
        [SDKProperty("longest_spot_duration_hours_gt", IsQuery = true)]
        [JsonProperty("longest_spot_duration_hours_gt", NullValueHandling = NullValueHandling.Ignore)]
        public int? LongestSpotDurationHoursGt { get; set; }

        /// <summary>
        /// 查询“竞价实例时长”的个数大于设置值的策略
        /// </summary>
        [SDKProperty("largest_spot_duration_count_gt", IsQuery = true)]
        [JsonProperty("largest_spot_duration_count_gt", NullValueHandling = NullValueHandling.Ignore)]
        public int? LargestSpotDurationCountGt { get; set; }

        /// <summary>
        /// 查询竞价实例时长等于设置值的策略
        /// </summary>
        [SDKProperty("longest_spot_duration_hours", IsQuery = true)]
        [JsonProperty("longest_spot_duration_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? LongestSpotDurationHours { get; set; }

        /// <summary>
        /// 查询“竞价实例时长”的个数等于设置值的策略
        /// </summary>
        [SDKProperty("largest_spot_duration_count", IsQuery = true)]
        [JsonProperty("largest_spot_duration_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LargestSpotDurationCount { get; set; }

        /// <summary>
        /// 中断策略。  取值范围：  - immediate：立即释放 - delay：延迟释放
        /// </summary>
        [SDKProperty("interruption_policy", IsQuery = true)]
        [JsonProperty("interruption_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InterruptionPolicyEnum InterruptionPolicy { get; set; }
        /// <summary>
        /// 单页面可显示的flavor条数最大值，默认是1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 以单页最后一条flavor的ID作为分页标记。
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
            sb.Append("class ListFlavorSellPoliciesRequest {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  sellStatus: ").Append(SellStatus).Append("\n");
            sb.Append("  sellMode: ").Append(SellMode).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  longestSpotDurationHoursGt: ").Append(LongestSpotDurationHoursGt).Append("\n");
            sb.Append("  largestSpotDurationCountGt: ").Append(LargestSpotDurationCountGt).Append("\n");
            sb.Append("  longestSpotDurationHours: ").Append(LongestSpotDurationHours).Append("\n");
            sb.Append("  largestSpotDurationCount: ").Append(LargestSpotDurationCount).Append("\n");
            sb.Append("  interruptionPolicy: ").Append(InterruptionPolicy).Append("\n");
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
            return this.Equals(input as ListFlavorSellPoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorSellPoliciesRequest input)
        {
            if (input == null) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.SellStatus != input.SellStatus) return false;
            if (this.SellMode != input.SellMode) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;
            if (this.LongestSpotDurationHoursGt != input.LongestSpotDurationHoursGt || (this.LongestSpotDurationHoursGt != null && !this.LongestSpotDurationHoursGt.Equals(input.LongestSpotDurationHoursGt))) return false;
            if (this.LargestSpotDurationCountGt != input.LargestSpotDurationCountGt || (this.LargestSpotDurationCountGt != null && !this.LargestSpotDurationCountGt.Equals(input.LargestSpotDurationCountGt))) return false;
            if (this.LongestSpotDurationHours != input.LongestSpotDurationHours || (this.LongestSpotDurationHours != null && !this.LongestSpotDurationHours.Equals(input.LongestSpotDurationHours))) return false;
            if (this.LargestSpotDurationCount != input.LargestSpotDurationCount || (this.LargestSpotDurationCount != null && !this.LargestSpotDurationCount.Equals(input.LargestSpotDurationCount))) return false;
            if (this.InterruptionPolicy != input.InterruptionPolicy) return false;
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
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                hashCode = hashCode * 59 + this.SellStatus.GetHashCode();
                hashCode = hashCode * 59 + this.SellMode.GetHashCode();
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.LongestSpotDurationHoursGt != null) hashCode = hashCode * 59 + this.LongestSpotDurationHoursGt.GetHashCode();
                if (this.LargestSpotDurationCountGt != null) hashCode = hashCode * 59 + this.LargestSpotDurationCountGt.GetHashCode();
                if (this.LongestSpotDurationHours != null) hashCode = hashCode * 59 + this.LongestSpotDurationHours.GetHashCode();
                if (this.LargestSpotDurationCount != null) hashCode = hashCode * 59 + this.LargestSpotDurationCount.GetHashCode();
                hashCode = hashCode * 59 + this.InterruptionPolicy.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
