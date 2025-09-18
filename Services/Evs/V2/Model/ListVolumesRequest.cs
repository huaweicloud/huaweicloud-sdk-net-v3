using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListVolumesRequest 
    {
        /// <summary>
        /// 查询不包含所选元数据的云硬盘
        /// </summary>
        /// <value>查询不包含所选元数据的云硬盘</value>
        [JsonConverter(typeof(EnumClassConverter<NotMetadataEnum>))]
        public class NotMetadataEnum
        {
            /// <summary>
            /// Enum _HW_PASSTHROUGH_TRUE_ for value: {\"hw:passthrough\":true}
            /// </summary>
            public static readonly NotMetadataEnum _HW_PASSTHROUGH_TRUE_ = new NotMetadataEnum("{\"hw:passthrough\":true}");

            /// <summary>
            /// Enum _HW_PASSTHROUGH_FALSE_ for value: {\"hw:passthrough\":false}
            /// </summary>
            public static readonly NotMetadataEnum _HW_PASSTHROUGH_FALSE_ = new NotMetadataEnum("{\"hw:passthrough\":false}");

            /// <summary>
            /// Enum ___SYSTEM__ENCRYPTED_1_ for value: {\"__system__encrypted\":1}
            /// </summary>
            public static readonly NotMetadataEnum ___SYSTEM__ENCRYPTED_1_ = new NotMetadataEnum("{\"__system__encrypted\":1}");

            /// <summary>
            /// Enum ___SYSTEM__ENCRYPTED_0_ for value: {\"__system__encrypted\":0}
            /// </summary>
            public static readonly NotMetadataEnum ___SYSTEM__ENCRYPTED_0_ = new NotMetadataEnum("{\"__system__encrypted\":0}");

            private static readonly Dictionary<string, NotMetadataEnum> StaticFields =
            new Dictionary<string, NotMetadataEnum>()
            {
                { "{\"hw:passthrough\":true}", _HW_PASSTHROUGH_TRUE_ },
                { "{\"hw:passthrough\":false}", _HW_PASSTHROUGH_FALSE_ },
                { "{\"__system__encrypted\":1}", ___SYSTEM__ENCRYPTED_1_ },
                { "{\"__system__encrypted\":0}", ___SYSTEM__ENCRYPTED_0_ },
            };

            private string _value;

            public NotMetadataEnum()
            {

            }

            public NotMetadataEnum(string value)
            {
                _value = value;
            }

            public static NotMetadataEnum FromValue(string value)
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

                if (this.Equals(obj as NotMetadataEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotMetadataEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotMetadataEnum a, NotMetadataEnum b)
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

            public static bool operator !=(NotMetadataEnum a, NotMetadataEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通过云硬盘ID进行分页查询。默认为查询第一页数据。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 磁盘名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 返回结果个数限制。默认值为1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 返回结果按该关键字排序，支持id，status，size，created_at等关键字，默认为“created_at”。
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 偏移量（偏移量为一个大于0小于磁盘总个数的整数，表示查询该偏移量后面的所有的磁盘）。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 返回结果按照降序或升序排列，默认为“desc”。 降序：desc 升序：asc
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 云硬盘状态，取值可参考：\&quot;[云硬盘状态](https://support.huaweicloud.com/api-evs/evs_04_0040.html)\&quot;。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 云硬盘元数据。
        /// </summary>
        [SDKProperty("metadata", IsQuery = true)]
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public string Metadata { get; set; }

        /// <summary>
        /// 可用区信息。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 是否为共享云硬盘。 true：表示为共享云硬盘。 false：表示为非共享云硬盘。
        /// </summary>
        [SDKProperty("multiattach", IsQuery = true)]
        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        /// <summary>
        /// 服务类型，仅支持EVS、DSS、DESS。
        /// </summary>
        [SDKProperty("service_type", IsQuery = true)]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 专属存储池ID，可过滤出该专属存储池下的所有云硬盘，必须精确匹配。
        /// </summary>
        [SDKProperty("dedicated_storage_id", IsQuery = true)]
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        /// <summary>
        /// 专属存储池的名字，可过滤出该专属存储池下的所有云硬盘，支持模糊匹配。
        /// </summary>
        [SDKProperty("dedicated_storage_name", IsQuery = true)]
        [JsonProperty("dedicated_storage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageName { get; set; }

        /// <summary>
        /// 云硬盘类型id。 通过\&quot;[查询云硬盘类型列表](https://support.huaweicloud.com/api-evs/evs_04_3035.html)\&quot;可以查到，即volume_types参数说明表格中的“id”
        /// </summary>
        [SDKProperty("volume_type_id", IsQuery = true)]
        [JsonProperty("volume_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeTypeId { get; set; }

        /// <summary>
        /// 云硬盘ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云硬盘id列表，格式为ids&#x3D;[&#39;id1&#39;,&#39;id2&#39;,...,&#39;idx&#39;]，返回“ids”中有效id的云硬盘详情，无效的id会被忽略。 支持查询最多60个id对应的云硬盘详情。 如果“id”和“ids”查询参数同时存在，“id”会被忽略。
        /// </summary>
        [SDKProperty("ids", IsQuery = true)]
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public string Ids { get; set; }

        /// <summary>
        /// 指定企业项目id进行过滤。 传入“all_granted_eps”，代表查询权限范围内的所有企业项目下的云硬盘。 &gt; 说明： &gt;  &gt; 关于企业项目ID的获取及企业项目特性的详细信息，请参考：\&quot;[企业管理用户指南](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0123692049.html)\&quot;。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 云服务器id。
        /// </summary>
        [SDKProperty("server_id", IsQuery = true)]
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 查询不包含所选元数据的云硬盘
        /// </summary>
        [SDKProperty("not_metadata", IsQuery = true)]
        [JsonProperty("not_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public NotMetadataEnum NotMetadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVolumesRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dedicatedStorageName: ").Append(DedicatedStorageName).Append("\n");
            sb.Append("  volumeTypeId: ").Append(VolumeTypeId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  notMetadata: ").Append(NotMetadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVolumesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVolumesRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Multiattach != input.Multiattach || (this.Multiattach != null && !this.Multiattach.Equals(input.Multiattach))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.DedicatedStorageId != input.DedicatedStorageId || (this.DedicatedStorageId != null && !this.DedicatedStorageId.Equals(input.DedicatedStorageId))) return false;
            if (this.DedicatedStorageName != input.DedicatedStorageName || (this.DedicatedStorageName != null && !this.DedicatedStorageName.Equals(input.DedicatedStorageName))) return false;
            if (this.VolumeTypeId != input.VolumeTypeId || (this.VolumeTypeId != null && !this.VolumeTypeId.Equals(input.VolumeTypeId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && !this.Ids.Equals(input.Ids))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.NotMetadata != input.NotMetadata) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Multiattach != null) hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.DedicatedStorageId != null) hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DedicatedStorageName != null) hashCode = hashCode * 59 + this.DedicatedStorageName.GetHashCode();
                if (this.VolumeTypeId != null) hashCode = hashCode * 59 + this.VolumeTypeId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                hashCode = hashCode * 59 + this.NotMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
