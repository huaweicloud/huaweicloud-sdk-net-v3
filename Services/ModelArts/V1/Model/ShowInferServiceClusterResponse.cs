using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInferServiceClusterResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 资源当前状态。 **取值范围：** - ACTIVE ：开启。 - PENDING ：待处理。 - INITIALIZING ：初始化中。 - INITIALIZE_FAILED ：初始化失败。 - DELETED ：已删除。 - DELETING ：删除中。 - DELETE_FAILED ：删除失败。 - MIGRATING : 迁移中。
        /// </summary>
        /// <value>**参数解释：** 资源当前状态。 **取值范围：** - ACTIVE ：开启。 - PENDING ：待处理。 - INITIALIZING ：初始化中。 - INITIALIZE_FAILED ：初始化失败。 - DELETED ：已删除。 - DELETING ：删除中。 - DELETE_FAILED ：删除失败。 - MIGRATING : 迁移中。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            public static readonly StatusEnum PENDING = new StatusEnum("PENDING");

            /// <summary>
            /// Enum INITIALIZING for value: INITIALIZING
            /// </summary>
            public static readonly StatusEnum INITIALIZING = new StatusEnum("INITIALIZING");

            /// <summary>
            /// Enum INITIALIZE_FAILED for value: INITIALIZE_FAILED
            /// </summary>
            public static readonly StatusEnum INITIALIZE_FAILED = new StatusEnum("INITIALIZE_FAILED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StatusEnum DELETE_FAILED = new StatusEnum("DELETE_FAILED");

            /// <summary>
            /// Enum MIGRATING for value: MIGRATING
            /// </summary>
            public static readonly StatusEnum MIGRATING = new StatusEnum("MIGRATING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "PENDING", PENDING },
                { "INITIALIZING", INITIALIZING },
                { "INITIALIZE_FAILED", INITIALIZE_FAILED },
                { "DELETED", DELETED },
                { "DELETING", DELETING },
                { "DELETE_FAILED", DELETE_FAILED },
                { "MIGRATING", MIGRATING },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 专属池类型。 **取值范围：** - MANAGED ：公共。 - MANAGED_ROMA ：公共。 - DEDICATED ：专属。 - DEDICATED_ROMA ：专属。
        /// </summary>
        /// <value>**参数解释：** 专属池类型。 **取值范围：** - MANAGED ：公共。 - MANAGED_ROMA ：公共。 - DEDICATED ：专属。 - DEDICATED_ROMA ：专属。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum MANAGED for value: MANAGED
            /// </summary>
            public static readonly TypeEnum MANAGED = new TypeEnum("MANAGED");

            /// <summary>
            /// Enum MANAGED_ROMA for value: MANAGED_ROMA
            /// </summary>
            public static readonly TypeEnum MANAGED_ROMA = new TypeEnum("MANAGED_ROMA");

            /// <summary>
            /// Enum DEDICATED for value: DEDICATED
            /// </summary>
            public static readonly TypeEnum DEDICATED = new TypeEnum("DEDICATED");

            /// <summary>
            /// Enum DEDICATED_ROMA for value: DEDICATED_ROMA
            /// </summary>
            public static readonly TypeEnum DEDICATED_ROMA = new TypeEnum("DEDICATED_ROMA");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "MANAGED", MANAGED },
                { "MANAGED_ROMA", MANAGED_ROMA },
                { "DEDICATED", DEDICATED },
                { "DEDICATED_ROMA", DEDICATED_ROMA },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 工作空间ID。未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 资源池cceID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("logic_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicClusterId { get; set; }

        /// <summary>
        /// **参数解释：** 资源当前状态。 **取值范围：** - ACTIVE ：开启。 - PENDING ：待处理。 - INITIALIZING ：初始化中。 - INITIALIZE_FAILED ：初始化失败。 - DELETED ：已删除。 - DELETING ：删除中。 - DELETE_FAILED ：删除失败。 - MIGRATING : 迁移中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释：** 专属资源池ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释：** 专属池类型。 **取值范围：** - MANAGED ：公共。 - MANAGED_ROMA ：公共。 - DEDICATED ：专属。 - DEDICATED_ROMA ：专属。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 资源池类型。
        /// </summary>
        [JsonProperty("resource_categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceCategories { get; set; }

        /// <summary>
        /// **参数解释：** [用户项目ID](tag:hws,hws_hk,fcs,fcs_super)[资源空间ID](tag:hcs,hcs_sm)。获取方法请参见[[获取项目ID和名称](modelarts_03_0147.xml)](tag:hws,hws_hk,fcs,fcs_super)[[获取资源空间ID和名称](modelarts_03_0147.xml)](tag:hcs,hcs_sm)。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 资源池启用的时间，UTC毫秒。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 资源池最后更新的时间，UTC毫秒。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 当前专属池支持的规格。
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<InferFlavor> Flavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInferServiceClusterResponse {\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  logicClusterId: ").Append(LogicClusterId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  resourceCategories: ").Append(ResourceCategories).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInferServiceClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInferServiceClusterResponse input)
        {
            if (input == null) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.LogicClusterId != input.LogicClusterId || (this.LogicClusterId != null && !this.LogicClusterId.Equals(input.LogicClusterId))) return false;
            if (this.Status != input.Status) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Type != input.Type) return false;
            if (this.ResourceCategories != input.ResourceCategories || (this.ResourceCategories != null && input.ResourceCategories != null && !this.ResourceCategories.SequenceEqual(input.ResourceCategories))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.Flavors != input.Flavors || (this.Flavors != null && input.Flavors != null && !this.Flavors.SequenceEqual(input.Flavors))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.LogicClusterId != null) hashCode = hashCode * 59 + this.LogicClusterId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ResourceCategories != null) hashCode = hashCode * 59 + this.ResourceCategories.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Flavors != null) hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
