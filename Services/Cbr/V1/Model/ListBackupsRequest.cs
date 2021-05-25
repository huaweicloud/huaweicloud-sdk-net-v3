using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListBackupsRequest 
    {
        /// <summary>
        /// 备份类型
        /// </summary>
        /// <value>备份类型</value>
        [JsonConverter(typeof(EnumClassConverter<ImageTypeEnum>))]
        public class ImageTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly ImageTypeEnum BACKUP = new ImageTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly ImageTypeEnum REPLICATION = new ImageTypeEnum("replication");

            private static readonly Dictionary<string, ImageTypeEnum> StaticFields =
            new Dictionary<string, ImageTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string Value;

            public ImageTypeEnum(string value)
            {
                Value = value;
            }

            public static ImageTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ImageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ImageTypeEnum a, ImageTypeEnum b)
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

            public static bool operator !=(ImageTypeEnum a, ImageTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资源类型
        /// </summary>
        /// <value>资源类型</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum OS_CINDER_VOLUME for value: OS::Cinder::Volume
            /// </summary>
            public static readonly ResourceTypeEnum OS_CINDER_VOLUME = new ResourceTypeEnum("OS::Cinder::Volume");

            /// <summary>
            /// Enum OS_NOVA_SERVER for value: OS::Nova::Server
            /// </summary>
            public static readonly ResourceTypeEnum OS_NOVA_SERVER = new ResourceTypeEnum("OS::Nova::Server");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "OS::Cinder::Volume", OS_CINDER_VOLUME },
                { "OS::Nova::Server", OS_NOVA_SERVER },
            };

            private string Value;

            public ResourceTypeEnum(string value)
            {
                Value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 状态
        /// </summary>
        /// <value>状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum PROTECTING for value: protecting
            /// </summary>
            public static readonly StatusEnum PROTECTING = new StatusEnum("protecting");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            /// <summary>
            /// Enum RESTORING for value: restoring
            /// </summary>
            public static readonly StatusEnum RESTORING = new StatusEnum("restoring");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("error");

            /// <summary>
            /// Enum WAITING_PROTECT for value: waiting_protect
            /// </summary>
            public static readonly StatusEnum WAITING_PROTECT = new StatusEnum("waiting_protect");

            /// <summary>
            /// Enum WAITING_DELETE for value: waiting_delete
            /// </summary>
            public static readonly StatusEnum WAITING_DELETE = new StatusEnum("waiting_delete");

            /// <summary>
            /// Enum WAITING_RESTORE for value: waiting_restore
            /// </summary>
            public static readonly StatusEnum WAITING_RESTORE = new StatusEnum("waiting_restore");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "available", AVAILABLE },
                { "protecting", PROTECTING },
                { "deleting", DELETING },
                { "restoring", RESTORING },
                { "error", ERROR },
                { "waiting_protect", WAITING_PROTECT },
                { "waiting_delete", WAITING_DELETE },
                { "waiting_restore", WAITING_RESTORE },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 持有类型，私有的private/共享的shared/全部all_granted，默认只查询private。
        /// </summary>
        /// <value>持有类型，私有的private/共享的shared/全部all_granted，默认只查询private。</value>
        [JsonConverter(typeof(EnumClassConverter<OwnTypeEnum>))]
        public class OwnTypeEnum
        {
            /// <summary>
            /// Enum ALL_GRANTED for value: all_granted
            /// </summary>
            public static readonly OwnTypeEnum ALL_GRANTED = new OwnTypeEnum("all_granted");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly OwnTypeEnum PRIVATE = new OwnTypeEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly OwnTypeEnum SHARED = new OwnTypeEnum("shared");

            private static readonly Dictionary<string, OwnTypeEnum> StaticFields =
            new Dictionary<string, OwnTypeEnum>()
            {
                { "all_granted", ALL_GRANTED },
                { "private", PRIVATE },
                { "shared", SHARED },
            };

            private string Value;

            public OwnTypeEnum(string value)
            {
                Value = value;
            }

            public static OwnTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as OwnTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OwnTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OwnTypeEnum a, OwnTypeEnum b)
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

            public static bool operator !=(OwnTypeEnum a, OwnTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 共享状态
        /// </summary>
        /// <value>共享状态</value>
        [JsonConverter(typeof(EnumClassConverter<MemberStatusEnum>))]
        public class MemberStatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: pending
            /// </summary>
            public static readonly MemberStatusEnum PENDING = new MemberStatusEnum("pending");

            /// <summary>
            /// Enum ACCEPT for value: accept
            /// </summary>
            public static readonly MemberStatusEnum ACCEPT = new MemberStatusEnum("accept");

            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly MemberStatusEnum REJECT = new MemberStatusEnum("reject");

            private static readonly Dictionary<string, MemberStatusEnum> StaticFields =
            new Dictionary<string, MemberStatusEnum>()
            {
                { "pending", PENDING },
                { "accept", ACCEPT },
                { "reject", REJECT },
            };

            private string Value;

            public MemberStatusEnum(string value)
            {
                Value = value;
            }

            public static MemberStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as MemberStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MemberStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MemberStatusEnum a, MemberStatusEnum b)
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

            public static bool operator !=(MemberStatusEnum a, MemberStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 还原点ID
        /// </summary>
        [SDKProperty("checkpoint_id", IsQuery = true)]
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 专属云
        /// </summary>
        [SDKProperty("dec", IsQuery = true)]
        [JsonProperty("dec", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dec { get; set; }

        /// <summary>
        /// 备份产生时间范围的结束时间，格式为%YYYY-%mm-%ddT%HH:%MM:%SSZ，例如2018-02-01T12:00:00Z
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 备份类型
        /// </summary>
        [SDKProperty("image_type", IsQuery = true)]
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum ImageType { get; set; }
        /// <summary>
        /// 每页显示的条目数量，正整数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一次查询最后一条的id
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 偏移值，正整数
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 支持按az来过滤
        /// </summary>
        [SDKProperty("resource_az", IsQuery = true)]
        [JsonProperty("resource_az", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceAz { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [SDKProperty("resource_id", IsQuery = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// sort的内容为一组由逗号分隔的属性及可选排序方向组成，形如&lt;key1&gt;[:&lt;direction&gt;],&lt;key2&gt;[:&lt;direction&gt;],其中direction的取值为asc (升序) 或 desc (降序),如没有传入direction参数，默认为降序，sort内容的长度限制为255个字符。key取值范围:[created_at，updated_at，name，status，protected_at，id]
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// 备份产生时间范围的开始时间，格式为%YYYY-%mm-%ddT%HH:%MM:%SSZ，例如2018-02-01T12:00:00Z
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 存储库ID
        /// </summary>
        [SDKProperty("vault_id", IsQuery = true)]
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// 企业项目id或all_granted_eps，all_granted_eps表示查询用户有权限的所有企业项目id
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 持有类型，私有的private/共享的shared/全部all_granted，默认只查询private。
        /// </summary>
        [SDKProperty("own_type", IsQuery = true)]
        [JsonProperty("own_type", NullValueHandling = NullValueHandling.Ignore)]
        public OwnTypeEnum OwnType { get; set; }
        /// <summary>
        /// 共享状态
        /// </summary>
        [SDKProperty("member_status", IsQuery = true)]
        [JsonProperty("member_status", NullValueHandling = NullValueHandling.Ignore)]
        public MemberStatusEnum MemberStatus { get; set; }
        /// <summary>
        /// 父备份ID
        /// </summary>
        [SDKProperty("parent_id", IsQuery = true)]
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 根据存储库使用率过滤备份，取值范围 [1, 100]，含1和100。例如，used_percent&#x3D;80，表示筛选所属存储库使用率大于等于80%的所有备份。
        /// </summary>
        [SDKProperty("used_percent", IsQuery = true)]
        [JsonProperty("used_percent", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedPercent { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupsRequest {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  dec: ").Append(Dec).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  resourceAz: ").Append(ResourceAz).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ownType: ").Append(OwnType).Append("\n");
            sb.Append("  memberStatus: ").Append(MemberStatus).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  usedPercent: ").Append(UsedPercent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckpointId == input.CheckpointId ||
                    (this.CheckpointId != null &&
                    this.CheckpointId.Equals(input.CheckpointId))
                ) && 
                (
                    this.Dec == input.Dec ||
                    (this.Dec != null &&
                    this.Dec.Equals(input.Dec))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.ResourceAz == input.ResourceAz ||
                    (this.ResourceAz != null &&
                    this.ResourceAz.Equals(input.ResourceAz))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.OwnType == input.OwnType ||
                    (this.OwnType != null &&
                    this.OwnType.Equals(input.OwnType))
                ) && 
                (
                    this.MemberStatus == input.MemberStatus ||
                    (this.MemberStatus != null &&
                    this.MemberStatus.Equals(input.MemberStatus))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.UsedPercent == input.UsedPercent ||
                    (this.UsedPercent != null &&
                    this.UsedPercent.Equals(input.UsedPercent))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CheckpointId != null)
                    hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.Dec != null)
                    hashCode = hashCode * 59 + this.Dec.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ImageType != null)
                    hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.ResourceAz != null)
                    hashCode = hashCode * 59 + this.ResourceAz.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultId != null)
                    hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.OwnType != null)
                    hashCode = hashCode * 59 + this.OwnType.GetHashCode();
                if (this.MemberStatus != null)
                    hashCode = hashCode * 59 + this.MemberStatus.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.UsedPercent != null)
                    hashCode = hashCode * 59 + this.UsedPercent.GetHashCode();
                return hashCode;
            }
        }
    }
}
