using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UnblockRecordResponseUnblockRecord 
    {
        /// <summary>
        /// 解封类型。manual：人工；automatic：自动
        /// </summary>
        /// <value>解封类型。manual：人工；automatic：自动</value>
        [JsonConverter(typeof(EnumClassConverter<UnblockTypeEnum>))]
        public class UnblockTypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly UnblockTypeEnum MANUAL = new UnblockTypeEnum("manual");

            /// <summary>
            /// Enum AUTOMATIC for value: automatic
            /// </summary>
            public static readonly UnblockTypeEnum AUTOMATIC = new UnblockTypeEnum("automatic");

            private static readonly Dictionary<string, UnblockTypeEnum> StaticFields =
            new Dictionary<string, UnblockTypeEnum>()
            {
                { "manual", MANUAL },
                { "automatic", AUTOMATIC },
            };

            private string _value;

            public UnblockTypeEnum()
            {

            }

            public UnblockTypeEnum(string value)
            {
                _value = value;
            }

            public static UnblockTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UnblockTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UnblockTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UnblockTypeEnum a, UnblockTypeEnum b)
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

            public static bool operator !=(UnblockTypeEnum a, UnblockTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 状态。unblocking：解封中；success：成功；failed：失败
        /// </summary>
        /// <value>状态。unblocking：解封中；success：成功；failed：失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum UNBLOCKING for value: unblocking
            /// </summary>
            public static readonly StatusEnum UNBLOCKING = new StatusEnum("unblocking");

            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "unblocking", UNBLOCKING },
                { "success", SUCCESS },
                { "failed", FAILED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 执行者
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }

        /// <summary>
        /// 封堵id
        /// </summary>
        [JsonProperty("block_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockId { get; set; }

        /// <summary>
        /// 封堵时间
        /// </summary>
        [JsonProperty("blocking_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BlockingTime { get; set; }

        /// <summary>
        /// 解封时间
        /// </summary>
        [JsonProperty("unblocking_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnblockingTime { get; set; }

        /// <summary>
        /// 解封类型。manual：人工；automatic：自动
        /// </summary>
        [JsonProperty("unblock_type", NullValueHandling = NullValueHandling.Ignore)]
        public UnblockTypeEnum UnblockType { get; set; }
        /// <summary>
        /// 状态。unblocking：解封中；success：成功；failed：失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("sort_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? SortTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnblockRecordResponseUnblockRecord {\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  blockId: ").Append(BlockId).Append("\n");
            sb.Append("  blockingTime: ").Append(BlockingTime).Append("\n");
            sb.Append("  unblockingTime: ").Append(UnblockingTime).Append("\n");
            sb.Append("  unblockType: ").Append(UnblockType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sortTime: ").Append(SortTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnblockRecordResponseUnblockRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnblockRecordResponseUnblockRecord input)
        {
            if (input == null) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;
            if (this.BlockId != input.BlockId || (this.BlockId != null && !this.BlockId.Equals(input.BlockId))) return false;
            if (this.BlockingTime != input.BlockingTime || (this.BlockingTime != null && !this.BlockingTime.Equals(input.BlockingTime))) return false;
            if (this.UnblockingTime != input.UnblockingTime || (this.UnblockingTime != null && !this.UnblockingTime.Equals(input.UnblockingTime))) return false;
            if (this.UnblockType != input.UnblockType) return false;
            if (this.Status != input.Status) return false;
            if (this.SortTime != input.SortTime || (this.SortTime != null && !this.SortTime.Equals(input.SortTime))) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.BlockId != null) hashCode = hashCode * 59 + this.BlockId.GetHashCode();
                if (this.BlockingTime != null) hashCode = hashCode * 59 + this.BlockingTime.GetHashCode();
                if (this.UnblockingTime != null) hashCode = hashCode * 59 + this.UnblockingTime.GetHashCode();
                hashCode = hashCode * 59 + this.UnblockType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SortTime != null) hashCode = hashCode * 59 + this.SortTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
