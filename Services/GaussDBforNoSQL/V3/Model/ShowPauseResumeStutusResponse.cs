using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPauseResumeStutusResponse : SdkResponse
    {
        /// <summary>
        /// 容灾实例数据同步状态 - NA：实例尚未搭建容灾关系 - NEW：尚未启动的数据同步状态 - SYNCING：数据同步正常进行中 - SUSPENDING：正在暂停数据同步 - SUSPENDED：数据同步已暂停 - RECOVERYING：正在恢复数据同步
        /// </summary>
        /// <value>容灾实例数据同步状态 - NA：实例尚未搭建容灾关系 - NEW：尚未启动的数据同步状态 - SYNCING：数据同步正常进行中 - SUSPENDING：正在暂停数据同步 - SUSPENDED：数据同步已暂停 - RECOVERYING：正在恢复数据同步</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NA for value: NA
            /// </summary>
            public static readonly StatusEnum NA = new StatusEnum("NA");

            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            public static readonly StatusEnum NEW = new StatusEnum("NEW");

            /// <summary>
            /// Enum SYNCING for value: SYNCING
            /// </summary>
            public static readonly StatusEnum SYNCING = new StatusEnum("SYNCING");

            /// <summary>
            /// Enum SUSPENDING for value: SUSPENDING
            /// </summary>
            public static readonly StatusEnum SUSPENDING = new StatusEnum("SUSPENDING");

            /// <summary>
            /// Enum SUSPENDED for value: SUSPENDED
            /// </summary>
            public static readonly StatusEnum SUSPENDED = new StatusEnum("SUSPENDED");

            /// <summary>
            /// Enum RECOVERYING for value: RECOVERYING
            /// </summary>
            public static readonly StatusEnum RECOVERYING = new StatusEnum("RECOVERYING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "NA", NA },
                { "NEW", NEW },
                { "SYNCING", SYNCING },
                { "SUSPENDING", SUSPENDING },
                { "SUSPENDED", SUSPENDED },
                { "RECOVERYING", RECOVERYING },
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
        /// 主实例id
        /// </summary>
        [JsonProperty("master_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterInstanceId { get; set; }

        /// <summary>
        /// 备实例id
        /// </summary>
        [JsonProperty("slave_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveInstanceId { get; set; }

        /// <summary>
        /// 容灾实例数据同步状态 - NA：实例尚未搭建容灾关系 - NEW：尚未启动的数据同步状态 - SYNCING：数据同步正常进行中 - SUSPENDING：正在暂停数据同步 - SUSPENDED：数据同步已暂停 - RECOVERYING：正在恢复数据同步
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_sync_indicators", NullValueHandling = NullValueHandling.Ignore)]
        public NoSQLDrDateSyncIndicators DataSyncIndicators { get; set; }

        /// <summary>
        /// 切换或倒换RPO和RTO值，仅当请求实例id为主实例时有值
        /// </summary>
        [JsonProperty("rto_and_rpo_indicators", NullValueHandling = NullValueHandling.Ignore)]
        public List<NoSQLDrRpoAndRto> RtoAndRpoIndicators { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPauseResumeStutusResponse {\n");
            sb.Append("  masterInstanceId: ").Append(MasterInstanceId).Append("\n");
            sb.Append("  slaveInstanceId: ").Append(SlaveInstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  dataSyncIndicators: ").Append(DataSyncIndicators).Append("\n");
            sb.Append("  rtoAndRpoIndicators: ").Append(RtoAndRpoIndicators).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPauseResumeStutusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPauseResumeStutusResponse input)
        {
            if (input == null) return false;
            if (this.MasterInstanceId != input.MasterInstanceId || (this.MasterInstanceId != null && !this.MasterInstanceId.Equals(input.MasterInstanceId))) return false;
            if (this.SlaveInstanceId != input.SlaveInstanceId || (this.SlaveInstanceId != null && !this.SlaveInstanceId.Equals(input.SlaveInstanceId))) return false;
            if (this.Status != input.Status) return false;
            if (this.DataSyncIndicators != input.DataSyncIndicators || (this.DataSyncIndicators != null && !this.DataSyncIndicators.Equals(input.DataSyncIndicators))) return false;
            if (this.RtoAndRpoIndicators != input.RtoAndRpoIndicators || (this.RtoAndRpoIndicators != null && input.RtoAndRpoIndicators != null && !this.RtoAndRpoIndicators.SequenceEqual(input.RtoAndRpoIndicators))) return false;

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
                if (this.MasterInstanceId != null) hashCode = hashCode * 59 + this.MasterInstanceId.GetHashCode();
                if (this.SlaveInstanceId != null) hashCode = hashCode * 59 + this.SlaveInstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DataSyncIndicators != null) hashCode = hashCode * 59 + this.DataSyncIndicators.GetHashCode();
                if (this.RtoAndRpoIndicators != null) hashCode = hashCode * 59 + this.RtoAndRpoIndicators.GetHashCode();
                return hashCode;
            }
        }
    }
}
