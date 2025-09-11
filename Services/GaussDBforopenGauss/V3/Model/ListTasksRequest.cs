using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTasksRequest 
    {
        /// <summary>
        /// 任务状态。
        /// </summary>
        /// <value>任务状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("Running");

            /// <summary>
            /// Enum COMPLETED for value: Completed
            /// </summary>
            public static readonly StatusEnum COMPLETED = new StatusEnum("Completed");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("Failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Running", RUNNING },
                { "Completed", COMPLETED },
                { "Failed", FAILED },
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
        /// 任务名称。
        /// </summary>
        /// <value>任务名称。</value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum CREATEGAUSSDBV5INSTANCE for value: CreateGaussDBV5Instance
            /// </summary>
            public static readonly NameEnum CREATEGAUSSDBV5INSTANCE = new NameEnum("CreateGaussDBV5Instance");

            /// <summary>
            /// Enum BACKUPSNAPSHOTGAUSSDBV5ININSTANCE for value: BackupSnapshotGaussDBV5InInstance
            /// </summary>
            public static readonly NameEnum BACKUPSNAPSHOTGAUSSDBV5ININSTANCE = new NameEnum("BackupSnapshotGaussDBV5InInstance");

            /// <summary>
            /// Enum CLONEGAUSSDBV5NEWINSTANCE for value: CloneGaussDBV5NewInstance
            /// </summary>
            public static readonly NameEnum CLONEGAUSSDBV5NEWINSTANCE = new NameEnum("CloneGaussDBV5NewInstance");

            /// <summary>
            /// Enum RESTOREGAUSSDBV5ININSTANCE for value: RestoreGaussDBV5InInstance
            /// </summary>
            public static readonly NameEnum RESTOREGAUSSDBV5ININSTANCE = new NameEnum("RestoreGaussDBV5InInstance");

            /// <summary>
            /// Enum RESTOREGAUSSDBV5ININSTANCETOEXISTEDINST for value: RestoreGaussDBV5InInstanceToExistedInst
            /// </summary>
            public static readonly NameEnum RESTOREGAUSSDBV5ININSTANCETOEXISTEDINST = new NameEnum("RestoreGaussDBV5InInstanceToExistedInst");

            /// <summary>
            /// Enum DELETEGAUSSDBV5INSTANCE for value: DeleteGaussDBV5Instance
            /// </summary>
            public static readonly NameEnum DELETEGAUSSDBV5INSTANCE = new NameEnum("DeleteGaussDBV5Instance");

            /// <summary>
            /// Enum ENLARGEGAUSSDBV5VOLUME for value: EnlargeGaussDBV5Volume
            /// </summary>
            public static readonly NameEnum ENLARGEGAUSSDBV5VOLUME = new NameEnum("EnlargeGaussDBV5Volume");

            /// <summary>
            /// Enum RESIZEGAUSSDBV5FLAVOR for value: ResizeGaussDBV5Flavor
            /// </summary>
            public static readonly NameEnum RESIZEGAUSSDBV5FLAVOR = new NameEnum("ResizeGaussDBV5Flavor");

            /// <summary>
            /// Enum GAUSSDBV5EXPANDCLUSTERCN for value: GaussDBV5ExpandClusterCN
            /// </summary>
            public static readonly NameEnum GAUSSDBV5EXPANDCLUSTERCN = new NameEnum("GaussDBV5ExpandClusterCN");

            /// <summary>
            /// Enum GAUSSDBV5EXPANDCLUSTERDN for value: GaussDBV5ExpandClusterDN
            /// </summary>
            public static readonly NameEnum GAUSSDBV5EXPANDCLUSTERDN = new NameEnum("GaussDBV5ExpandClusterDN");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "CreateGaussDBV5Instance", CREATEGAUSSDBV5INSTANCE },
                { "BackupSnapshotGaussDBV5InInstance", BACKUPSNAPSHOTGAUSSDBV5ININSTANCE },
                { "CloneGaussDBV5NewInstance", CLONEGAUSSDBV5NEWINSTANCE },
                { "RestoreGaussDBV5InInstance", RESTOREGAUSSDBV5ININSTANCE },
                { "RestoreGaussDBV5InInstanceToExistedInst", RESTOREGAUSSDBV5ININSTANCETOEXISTEDINST },
                { "DeleteGaussDBV5Instance", DELETEGAUSSDBV5INSTANCE },
                { "EnlargeGaussDBV5Volume", ENLARGEGAUSSDBV5VOLUME },
                { "ResizeGaussDBV5Flavor", RESIZEGAUSSDBV5FLAVOR },
                { "GaussDBV5ExpandClusterCN", GAUSSDBV5EXPANDCLUSTERCN },
                { "GaussDBV5ExpandClusterDN", GAUSSDBV5EXPANDCLUSTERDN },
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
        /// **参数解释**: 语言。 **约束限制**: 不涉及。 **取值范围**:   - zh-cn   - en-us  **默认取值**: en-us
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 任务名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// 开始时间。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为100，不能为负数，最小值为1，最大值为100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTasksRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTasksRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.Status != input.Status) return false;
            if (this.Name != input.Name) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
