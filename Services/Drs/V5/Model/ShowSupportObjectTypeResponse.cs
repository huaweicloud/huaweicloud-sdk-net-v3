using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSupportObjectTypeResponse : SdkResponse
    {

        /// <summary>
        /// 全量任务是否支持对象选择。
        /// </summary>
        [JsonProperty("is_full_trans_support_object", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFullTransSupportObject { get; set; }

        /// <summary>
        /// 增量任务是否支持对象选择。
        /// </summary>
        [JsonProperty("is_incre_trans_support_object", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIncreTransSupportObject { get; set; }

        /// <summary>
        /// 全量加增量任务是否支持对象选择。
        /// </summary>
        [JsonProperty("is_full_incre_trans_support_object", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFullIncreTransSupportObject { get; set; }

        /// <summary>
        /// 支持对象导入的引引擎。
        /// </summary>
        [JsonProperty("support_object_import_engine", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportObjectImportEngine { get; set; }

        /// <summary>
        /// 是否支持列映射。
        /// </summary>
        [JsonProperty("is_support_column_mapping", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportColumnMapping { get; set; }

        /// <summary>
        /// 库是否支持搜索。
        /// </summary>
        [JsonProperty("is_database_support_search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDatabaseSupportSearch { get; set; }

        /// <summary>
        /// schema是否支持搜索。
        /// </summary>
        [JsonProperty("is_schema_support_search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSchemaSupportSearch { get; set; }

        /// <summary>
        /// 表是否支持搜索。
        /// </summary>
        [JsonProperty("is_table_support_search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTableSupportSearch { get; set; }

        /// <summary>
        /// 对象导入支持的文件大小。
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSize { get; set; }

        /// <summary>
        /// 上一次选择迁移对象或者同步对象的方式。 - srcImportObject：当前任务上次选择的方式为导入方式
        /// </summary>
        [JsonProperty("previous_select", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousSelect { get; set; }

        /// <summary>
        /// 对象导入类型。 - table：表级 - database：库级
        /// </summary>
        [JsonProperty("import_level", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportLevel { get; set; }

        /// <summary>
        /// 取值： - true： 当前任务上次选择列加工方式为导入方式 - false 或者 空：当前任务上次选择列加工方式为手动选择方式
        /// </summary>
        [JsonProperty("is_import_cloumn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImportCloumn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSupportObjectTypeResponse {\n");
            sb.Append("  isFullTransSupportObject: ").Append(IsFullTransSupportObject).Append("\n");
            sb.Append("  isIncreTransSupportObject: ").Append(IsIncreTransSupportObject).Append("\n");
            sb.Append("  isFullIncreTransSupportObject: ").Append(IsFullIncreTransSupportObject).Append("\n");
            sb.Append("  supportObjectImportEngine: ").Append(SupportObjectImportEngine).Append("\n");
            sb.Append("  isSupportColumnMapping: ").Append(IsSupportColumnMapping).Append("\n");
            sb.Append("  isDatabaseSupportSearch: ").Append(IsDatabaseSupportSearch).Append("\n");
            sb.Append("  isSchemaSupportSearch: ").Append(IsSchemaSupportSearch).Append("\n");
            sb.Append("  isTableSupportSearch: ").Append(IsTableSupportSearch).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  previousSelect: ").Append(PreviousSelect).Append("\n");
            sb.Append("  importLevel: ").Append(ImportLevel).Append("\n");
            sb.Append("  isImportCloumn: ").Append(IsImportCloumn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSupportObjectTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSupportObjectTypeResponse input)
        {
            if (input == null) return false;
            if (this.IsFullTransSupportObject != input.IsFullTransSupportObject || (this.IsFullTransSupportObject != null && !this.IsFullTransSupportObject.Equals(input.IsFullTransSupportObject))) return false;
            if (this.IsIncreTransSupportObject != input.IsIncreTransSupportObject || (this.IsIncreTransSupportObject != null && !this.IsIncreTransSupportObject.Equals(input.IsIncreTransSupportObject))) return false;
            if (this.IsFullIncreTransSupportObject != input.IsFullIncreTransSupportObject || (this.IsFullIncreTransSupportObject != null && !this.IsFullIncreTransSupportObject.Equals(input.IsFullIncreTransSupportObject))) return false;
            if (this.SupportObjectImportEngine != input.SupportObjectImportEngine || (this.SupportObjectImportEngine != null && input.SupportObjectImportEngine != null && !this.SupportObjectImportEngine.SequenceEqual(input.SupportObjectImportEngine))) return false;
            if (this.IsSupportColumnMapping != input.IsSupportColumnMapping || (this.IsSupportColumnMapping != null && !this.IsSupportColumnMapping.Equals(input.IsSupportColumnMapping))) return false;
            if (this.IsDatabaseSupportSearch != input.IsDatabaseSupportSearch || (this.IsDatabaseSupportSearch != null && !this.IsDatabaseSupportSearch.Equals(input.IsDatabaseSupportSearch))) return false;
            if (this.IsSchemaSupportSearch != input.IsSchemaSupportSearch || (this.IsSchemaSupportSearch != null && !this.IsSchemaSupportSearch.Equals(input.IsSchemaSupportSearch))) return false;
            if (this.IsTableSupportSearch != input.IsTableSupportSearch || (this.IsTableSupportSearch != null && !this.IsTableSupportSearch.Equals(input.IsTableSupportSearch))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.PreviousSelect != input.PreviousSelect || (this.PreviousSelect != null && !this.PreviousSelect.Equals(input.PreviousSelect))) return false;
            if (this.ImportLevel != input.ImportLevel || (this.ImportLevel != null && !this.ImportLevel.Equals(input.ImportLevel))) return false;
            if (this.IsImportCloumn != input.IsImportCloumn || (this.IsImportCloumn != null && !this.IsImportCloumn.Equals(input.IsImportCloumn))) return false;

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
                if (this.IsFullTransSupportObject != null) hashCode = hashCode * 59 + this.IsFullTransSupportObject.GetHashCode();
                if (this.IsIncreTransSupportObject != null) hashCode = hashCode * 59 + this.IsIncreTransSupportObject.GetHashCode();
                if (this.IsFullIncreTransSupportObject != null) hashCode = hashCode * 59 + this.IsFullIncreTransSupportObject.GetHashCode();
                if (this.SupportObjectImportEngine != null) hashCode = hashCode * 59 + this.SupportObjectImportEngine.GetHashCode();
                if (this.IsSupportColumnMapping != null) hashCode = hashCode * 59 + this.IsSupportColumnMapping.GetHashCode();
                if (this.IsDatabaseSupportSearch != null) hashCode = hashCode * 59 + this.IsDatabaseSupportSearch.GetHashCode();
                if (this.IsSchemaSupportSearch != null) hashCode = hashCode * 59 + this.IsSchemaSupportSearch.GetHashCode();
                if (this.IsTableSupportSearch != null) hashCode = hashCode * 59 + this.IsTableSupportSearch.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.PreviousSelect != null) hashCode = hashCode * 59 + this.PreviousSelect.GetHashCode();
                if (this.ImportLevel != null) hashCode = hashCode * 59 + this.ImportLevel.GetHashCode();
                if (this.IsImportCloumn != null) hashCode = hashCode * 59 + this.IsImportCloumn.GetHashCode();
                return hashCode;
            }
        }
    }
}
