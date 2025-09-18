using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 度量项
    /// </summary>
    public class MetricInfo 
    {

        /// <summary>
        /// 代码规模
        /// </summary>
        [JsonProperty("code_size", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeSize { get; set; }

        /// <summary>
        /// 原始代码行数
        /// </summary>
        [JsonProperty("raw_lines", NullValueHandling = NullValueHandling.Ignore)]
        public string RawLines { get; set; }

        /// <summary>
        /// 函数总数
        /// </summary>
        [JsonProperty("methods_total", NullValueHandling = NullValueHandling.Ignore)]
        public string MethodsTotal { get; set; }

        /// <summary>
        /// 圈复杂度总数
        /// </summary>
        [JsonProperty("cyclomatic_complexity_total", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityTotal { get; set; }

        /// <summary>
        /// 平均圈复杂度
        /// </summary>
        [JsonProperty("cyclomatic_complexity_per_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityPerMethod { get; set; }

        /// <summary>
        /// 最大圈复杂度
        /// </summary>
        [JsonProperty("maximum_cyclomatic_complexity", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumCyclomaticComplexity { get; set; }

        /// <summary>
        /// 超大圈复杂度数
        /// </summary>
        [JsonProperty("huge_cyclomatic_complexity_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeCyclomaticComplexityTotal { get; set; }

        /// <summary>
        /// 超大圈复杂度比例
        /// </summary>
        [JsonProperty("huge_cyclomatic_complexity_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeCyclomaticComplexityRatio { get; set; }

        /// <summary>
        /// cca圈复杂度总数
        /// </summary>
        [JsonProperty("cca_cyclomatic_complexity_total", NullValueHandling = NullValueHandling.Ignore)]
        public string CcaCyclomaticComplexityTotal { get; set; }

        /// <summary>
        /// cca平均圈复杂度
        /// </summary>
        [JsonProperty("cca_cyclomatic_complexity_per_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CcaCyclomaticComplexityPerMethod { get; set; }

        /// <summary>
        /// cca最大圈复杂度
        /// </summary>
        [JsonProperty("maximum_cca_cyclomatic_complexity", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumCcaCyclomaticComplexity { get; set; }

        /// <summary>
        /// 超大圈复杂度函数总数
        /// </summary>
        [JsonProperty("huge_cca_cyclomatic_complexity_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeCcaCyclomaticComplexityTotal { get; set; }

        /// <summary>
        /// 圈复杂度满足度
        /// </summary>
        [JsonProperty("cyclomatic_complexity_adequacy", NullValueHandling = NullValueHandling.Ignore)]
        public string CyclomaticComplexityAdequacy { get; set; }

        /// <summary>
        /// 最大深度
        /// </summary>
        [JsonProperty("maximum_depth", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumDepth { get; set; }

        /// <summary>
        /// 超大深度数
        /// </summary>
        [JsonProperty("huge_depth_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeDepthTotal { get; set; }

        /// <summary>
        /// 超大深度占比
        /// </summary>
        [JsonProperty("huge_depth_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeDepthRatio { get; set; }

        /// <summary>
        /// 函数总行数
        /// </summary>
        [JsonProperty("method_lines", NullValueHandling = NullValueHandling.Ignore)]
        public string MethodLines { get; set; }

        /// <summary>
        /// 函数平均代码行
        /// </summary>
        [JsonProperty("lines_per_method", NullValueHandling = NullValueHandling.Ignore)]
        public string LinesPerMethod { get; set; }

        /// <summary>
        /// 超大函数数
        /// </summary>
        [JsonProperty("huge_method_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeMethodTotal { get; set; }

        /// <summary>
        /// 超大函数占比
        /// </summary>
        [JsonProperty("huge_method_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeMethodRatio { get; set; }

        /// <summary>
        /// 文件总数
        /// </summary>
        [JsonProperty("files_total", NullValueHandling = NullValueHandling.Ignore)]
        public string FilesTotal { get; set; }

        /// <summary>
        /// 目录总数
        /// </summary>
        [JsonProperty("folders_total", NullValueHandling = NullValueHandling.Ignore)]
        public string FoldersTotal { get; set; }

        /// <summary>
        /// 文件平均代码行
        /// </summary>
        [JsonProperty("lines_per_file", NullValueHandling = NullValueHandling.Ignore)]
        public string LinesPerFile { get; set; }

        /// <summary>
        /// 超大头文件数
        /// </summary>
        [JsonProperty("huge_headerfile_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeHeaderfileTotal { get; set; }

        /// <summary>
        /// 超大头文件占比
        /// </summary>
        [JsonProperty("huge_headerfile_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeHeaderfileRatio { get; set; }

        /// <summary>
        /// 超大源文件数
        /// </summary>
        [JsonProperty("huge_non_headerfile_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeNonHeaderfileTotal { get; set; }

        /// <summary>
        /// 超大源文件占比
        /// </summary>
        [JsonProperty("huge_non_headerfile_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeNonHeaderfileRatio { get; set; }

        /// <summary>
        /// 超大目录数
        /// </summary>
        [JsonProperty("huge_folder_total", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeFolderTotal { get; set; }

        /// <summary>
        /// 超大目录占比
        /// </summary>
        [JsonProperty("huge_folder_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string HugeFolderRatio { get; set; }

        /// <summary>
        /// 重复文件数
        /// </summary>
        [JsonProperty("file_duplication_total", NullValueHandling = NullValueHandling.Ignore)]
        public string FileDuplicationTotal { get; set; }

        /// <summary>
        /// 文件重复率
        /// </summary>
        [JsonProperty("file_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string FileDuplicationRatio { get; set; }

        /// <summary>
        /// 重复源文件数
        /// </summary>
        [JsonProperty("non_hfile_duplication_total", NullValueHandling = NullValueHandling.Ignore)]
        public string NonHfileDuplicationTotal { get; set; }

        /// <summary>
        /// 源文件重复率
        /// </summary>
        [JsonProperty("non_hfile_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string NonHfileDuplicationRatio { get; set; }

        /// <summary>
        /// 代码重复数
        /// </summary>
        [JsonProperty("code_duplication_total", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDuplicationTotal { get; set; }

        /// <summary>
        /// 代码重复率
        /// </summary>
        [JsonProperty("code_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeDuplicationRatio { get; set; }

        /// <summary>
        /// 源文件代码重复数
        /// </summary>
        [JsonProperty("non_hfile_code_duplication_total", NullValueHandling = NullValueHandling.Ignore)]
        public string NonHfileCodeDuplicationTotal { get; set; }

        /// <summary>
        /// 源文件代码重复率
        /// </summary>
        [JsonProperty("non_hfile_code_duplication_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string NonHfileCodeDuplicationRatio { get; set; }

        /// <summary>
        /// 危险函数总数
        /// </summary>
        [JsonProperty("unsafe_functions_total", NullValueHandling = NullValueHandling.Ignore)]
        public string UnsafeFunctionsTotal { get; set; }

        /// <summary>
        /// 危险函数密度
        /// </summary>
        [JsonProperty("unsafe_functions_kloc", NullValueHandling = NullValueHandling.Ignore)]
        public string UnsafeFunctionsKloc { get; set; }

        /// <summary>
        /// 冗余代码数
        /// </summary>
        [JsonProperty("redundant_code_total", NullValueHandling = NullValueHandling.Ignore)]
        public string RedundantCodeTotal { get; set; }

        /// <summary>
        /// 冗余代码块密度
        /// </summary>
        [JsonProperty("redundant_code_kloc", NullValueHandling = NullValueHandling.Ignore)]
        public string RedundantCodeKloc { get; set; }

        /// <summary>
        /// 抑制告警数
        /// </summary>
        [JsonProperty("warning_suppression_total", NullValueHandling = NullValueHandling.Ignore)]
        public string WarningSuppressionTotal { get; set; }

        /// <summary>
        /// 抑制告警密度
        /// </summary>
        [JsonProperty("warning_suppression_kloc", NullValueHandling = NullValueHandling.Ignore)]
        public string WarningSuppressionKloc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricInfo {\n");
            sb.Append("  codeSize: ").Append(CodeSize).Append("\n");
            sb.Append("  rawLines: ").Append(RawLines).Append("\n");
            sb.Append("  methodsTotal: ").Append(MethodsTotal).Append("\n");
            sb.Append("  cyclomaticComplexityTotal: ").Append(CyclomaticComplexityTotal).Append("\n");
            sb.Append("  cyclomaticComplexityPerMethod: ").Append(CyclomaticComplexityPerMethod).Append("\n");
            sb.Append("  maximumCyclomaticComplexity: ").Append(MaximumCyclomaticComplexity).Append("\n");
            sb.Append("  hugeCyclomaticComplexityTotal: ").Append(HugeCyclomaticComplexityTotal).Append("\n");
            sb.Append("  hugeCyclomaticComplexityRatio: ").Append(HugeCyclomaticComplexityRatio).Append("\n");
            sb.Append("  ccaCyclomaticComplexityTotal: ").Append(CcaCyclomaticComplexityTotal).Append("\n");
            sb.Append("  ccaCyclomaticComplexityPerMethod: ").Append(CcaCyclomaticComplexityPerMethod).Append("\n");
            sb.Append("  maximumCcaCyclomaticComplexity: ").Append(MaximumCcaCyclomaticComplexity).Append("\n");
            sb.Append("  hugeCcaCyclomaticComplexityTotal: ").Append(HugeCcaCyclomaticComplexityTotal).Append("\n");
            sb.Append("  cyclomaticComplexityAdequacy: ").Append(CyclomaticComplexityAdequacy).Append("\n");
            sb.Append("  maximumDepth: ").Append(MaximumDepth).Append("\n");
            sb.Append("  hugeDepthTotal: ").Append(HugeDepthTotal).Append("\n");
            sb.Append("  hugeDepthRatio: ").Append(HugeDepthRatio).Append("\n");
            sb.Append("  methodLines: ").Append(MethodLines).Append("\n");
            sb.Append("  linesPerMethod: ").Append(LinesPerMethod).Append("\n");
            sb.Append("  hugeMethodTotal: ").Append(HugeMethodTotal).Append("\n");
            sb.Append("  hugeMethodRatio: ").Append(HugeMethodRatio).Append("\n");
            sb.Append("  filesTotal: ").Append(FilesTotal).Append("\n");
            sb.Append("  foldersTotal: ").Append(FoldersTotal).Append("\n");
            sb.Append("  linesPerFile: ").Append(LinesPerFile).Append("\n");
            sb.Append("  hugeHeaderfileTotal: ").Append(HugeHeaderfileTotal).Append("\n");
            sb.Append("  hugeHeaderfileRatio: ").Append(HugeHeaderfileRatio).Append("\n");
            sb.Append("  hugeNonHeaderfileTotal: ").Append(HugeNonHeaderfileTotal).Append("\n");
            sb.Append("  hugeNonHeaderfileRatio: ").Append(HugeNonHeaderfileRatio).Append("\n");
            sb.Append("  hugeFolderTotal: ").Append(HugeFolderTotal).Append("\n");
            sb.Append("  hugeFolderRatio: ").Append(HugeFolderRatio).Append("\n");
            sb.Append("  fileDuplicationTotal: ").Append(FileDuplicationTotal).Append("\n");
            sb.Append("  fileDuplicationRatio: ").Append(FileDuplicationRatio).Append("\n");
            sb.Append("  nonHfileDuplicationTotal: ").Append(NonHfileDuplicationTotal).Append("\n");
            sb.Append("  nonHfileDuplicationRatio: ").Append(NonHfileDuplicationRatio).Append("\n");
            sb.Append("  codeDuplicationTotal: ").Append(CodeDuplicationTotal).Append("\n");
            sb.Append("  codeDuplicationRatio: ").Append(CodeDuplicationRatio).Append("\n");
            sb.Append("  nonHfileCodeDuplicationTotal: ").Append(NonHfileCodeDuplicationTotal).Append("\n");
            sb.Append("  nonHfileCodeDuplicationRatio: ").Append(NonHfileCodeDuplicationRatio).Append("\n");
            sb.Append("  unsafeFunctionsTotal: ").Append(UnsafeFunctionsTotal).Append("\n");
            sb.Append("  unsafeFunctionsKloc: ").Append(UnsafeFunctionsKloc).Append("\n");
            sb.Append("  redundantCodeTotal: ").Append(RedundantCodeTotal).Append("\n");
            sb.Append("  redundantCodeKloc: ").Append(RedundantCodeKloc).Append("\n");
            sb.Append("  warningSuppressionTotal: ").Append(WarningSuppressionTotal).Append("\n");
            sb.Append("  warningSuppressionKloc: ").Append(WarningSuppressionKloc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricInfo input)
        {
            if (input == null) return false;
            if (this.CodeSize != input.CodeSize || (this.CodeSize != null && !this.CodeSize.Equals(input.CodeSize))) return false;
            if (this.RawLines != input.RawLines || (this.RawLines != null && !this.RawLines.Equals(input.RawLines))) return false;
            if (this.MethodsTotal != input.MethodsTotal || (this.MethodsTotal != null && !this.MethodsTotal.Equals(input.MethodsTotal))) return false;
            if (this.CyclomaticComplexityTotal != input.CyclomaticComplexityTotal || (this.CyclomaticComplexityTotal != null && !this.CyclomaticComplexityTotal.Equals(input.CyclomaticComplexityTotal))) return false;
            if (this.CyclomaticComplexityPerMethod != input.CyclomaticComplexityPerMethod || (this.CyclomaticComplexityPerMethod != null && !this.CyclomaticComplexityPerMethod.Equals(input.CyclomaticComplexityPerMethod))) return false;
            if (this.MaximumCyclomaticComplexity != input.MaximumCyclomaticComplexity || (this.MaximumCyclomaticComplexity != null && !this.MaximumCyclomaticComplexity.Equals(input.MaximumCyclomaticComplexity))) return false;
            if (this.HugeCyclomaticComplexityTotal != input.HugeCyclomaticComplexityTotal || (this.HugeCyclomaticComplexityTotal != null && !this.HugeCyclomaticComplexityTotal.Equals(input.HugeCyclomaticComplexityTotal))) return false;
            if (this.HugeCyclomaticComplexityRatio != input.HugeCyclomaticComplexityRatio || (this.HugeCyclomaticComplexityRatio != null && !this.HugeCyclomaticComplexityRatio.Equals(input.HugeCyclomaticComplexityRatio))) return false;
            if (this.CcaCyclomaticComplexityTotal != input.CcaCyclomaticComplexityTotal || (this.CcaCyclomaticComplexityTotal != null && !this.CcaCyclomaticComplexityTotal.Equals(input.CcaCyclomaticComplexityTotal))) return false;
            if (this.CcaCyclomaticComplexityPerMethod != input.CcaCyclomaticComplexityPerMethod || (this.CcaCyclomaticComplexityPerMethod != null && !this.CcaCyclomaticComplexityPerMethod.Equals(input.CcaCyclomaticComplexityPerMethod))) return false;
            if (this.MaximumCcaCyclomaticComplexity != input.MaximumCcaCyclomaticComplexity || (this.MaximumCcaCyclomaticComplexity != null && !this.MaximumCcaCyclomaticComplexity.Equals(input.MaximumCcaCyclomaticComplexity))) return false;
            if (this.HugeCcaCyclomaticComplexityTotal != input.HugeCcaCyclomaticComplexityTotal || (this.HugeCcaCyclomaticComplexityTotal != null && !this.HugeCcaCyclomaticComplexityTotal.Equals(input.HugeCcaCyclomaticComplexityTotal))) return false;
            if (this.CyclomaticComplexityAdequacy != input.CyclomaticComplexityAdequacy || (this.CyclomaticComplexityAdequacy != null && !this.CyclomaticComplexityAdequacy.Equals(input.CyclomaticComplexityAdequacy))) return false;
            if (this.MaximumDepth != input.MaximumDepth || (this.MaximumDepth != null && !this.MaximumDepth.Equals(input.MaximumDepth))) return false;
            if (this.HugeDepthTotal != input.HugeDepthTotal || (this.HugeDepthTotal != null && !this.HugeDepthTotal.Equals(input.HugeDepthTotal))) return false;
            if (this.HugeDepthRatio != input.HugeDepthRatio || (this.HugeDepthRatio != null && !this.HugeDepthRatio.Equals(input.HugeDepthRatio))) return false;
            if (this.MethodLines != input.MethodLines || (this.MethodLines != null && !this.MethodLines.Equals(input.MethodLines))) return false;
            if (this.LinesPerMethod != input.LinesPerMethod || (this.LinesPerMethod != null && !this.LinesPerMethod.Equals(input.LinesPerMethod))) return false;
            if (this.HugeMethodTotal != input.HugeMethodTotal || (this.HugeMethodTotal != null && !this.HugeMethodTotal.Equals(input.HugeMethodTotal))) return false;
            if (this.HugeMethodRatio != input.HugeMethodRatio || (this.HugeMethodRatio != null && !this.HugeMethodRatio.Equals(input.HugeMethodRatio))) return false;
            if (this.FilesTotal != input.FilesTotal || (this.FilesTotal != null && !this.FilesTotal.Equals(input.FilesTotal))) return false;
            if (this.FoldersTotal != input.FoldersTotal || (this.FoldersTotal != null && !this.FoldersTotal.Equals(input.FoldersTotal))) return false;
            if (this.LinesPerFile != input.LinesPerFile || (this.LinesPerFile != null && !this.LinesPerFile.Equals(input.LinesPerFile))) return false;
            if (this.HugeHeaderfileTotal != input.HugeHeaderfileTotal || (this.HugeHeaderfileTotal != null && !this.HugeHeaderfileTotal.Equals(input.HugeHeaderfileTotal))) return false;
            if (this.HugeHeaderfileRatio != input.HugeHeaderfileRatio || (this.HugeHeaderfileRatio != null && !this.HugeHeaderfileRatio.Equals(input.HugeHeaderfileRatio))) return false;
            if (this.HugeNonHeaderfileTotal != input.HugeNonHeaderfileTotal || (this.HugeNonHeaderfileTotal != null && !this.HugeNonHeaderfileTotal.Equals(input.HugeNonHeaderfileTotal))) return false;
            if (this.HugeNonHeaderfileRatio != input.HugeNonHeaderfileRatio || (this.HugeNonHeaderfileRatio != null && !this.HugeNonHeaderfileRatio.Equals(input.HugeNonHeaderfileRatio))) return false;
            if (this.HugeFolderTotal != input.HugeFolderTotal || (this.HugeFolderTotal != null && !this.HugeFolderTotal.Equals(input.HugeFolderTotal))) return false;
            if (this.HugeFolderRatio != input.HugeFolderRatio || (this.HugeFolderRatio != null && !this.HugeFolderRatio.Equals(input.HugeFolderRatio))) return false;
            if (this.FileDuplicationTotal != input.FileDuplicationTotal || (this.FileDuplicationTotal != null && !this.FileDuplicationTotal.Equals(input.FileDuplicationTotal))) return false;
            if (this.FileDuplicationRatio != input.FileDuplicationRatio || (this.FileDuplicationRatio != null && !this.FileDuplicationRatio.Equals(input.FileDuplicationRatio))) return false;
            if (this.NonHfileDuplicationTotal != input.NonHfileDuplicationTotal || (this.NonHfileDuplicationTotal != null && !this.NonHfileDuplicationTotal.Equals(input.NonHfileDuplicationTotal))) return false;
            if (this.NonHfileDuplicationRatio != input.NonHfileDuplicationRatio || (this.NonHfileDuplicationRatio != null && !this.NonHfileDuplicationRatio.Equals(input.NonHfileDuplicationRatio))) return false;
            if (this.CodeDuplicationTotal != input.CodeDuplicationTotal || (this.CodeDuplicationTotal != null && !this.CodeDuplicationTotal.Equals(input.CodeDuplicationTotal))) return false;
            if (this.CodeDuplicationRatio != input.CodeDuplicationRatio || (this.CodeDuplicationRatio != null && !this.CodeDuplicationRatio.Equals(input.CodeDuplicationRatio))) return false;
            if (this.NonHfileCodeDuplicationTotal != input.NonHfileCodeDuplicationTotal || (this.NonHfileCodeDuplicationTotal != null && !this.NonHfileCodeDuplicationTotal.Equals(input.NonHfileCodeDuplicationTotal))) return false;
            if (this.NonHfileCodeDuplicationRatio != input.NonHfileCodeDuplicationRatio || (this.NonHfileCodeDuplicationRatio != null && !this.NonHfileCodeDuplicationRatio.Equals(input.NonHfileCodeDuplicationRatio))) return false;
            if (this.UnsafeFunctionsTotal != input.UnsafeFunctionsTotal || (this.UnsafeFunctionsTotal != null && !this.UnsafeFunctionsTotal.Equals(input.UnsafeFunctionsTotal))) return false;
            if (this.UnsafeFunctionsKloc != input.UnsafeFunctionsKloc || (this.UnsafeFunctionsKloc != null && !this.UnsafeFunctionsKloc.Equals(input.UnsafeFunctionsKloc))) return false;
            if (this.RedundantCodeTotal != input.RedundantCodeTotal || (this.RedundantCodeTotal != null && !this.RedundantCodeTotal.Equals(input.RedundantCodeTotal))) return false;
            if (this.RedundantCodeKloc != input.RedundantCodeKloc || (this.RedundantCodeKloc != null && !this.RedundantCodeKloc.Equals(input.RedundantCodeKloc))) return false;
            if (this.WarningSuppressionTotal != input.WarningSuppressionTotal || (this.WarningSuppressionTotal != null && !this.WarningSuppressionTotal.Equals(input.WarningSuppressionTotal))) return false;
            if (this.WarningSuppressionKloc != input.WarningSuppressionKloc || (this.WarningSuppressionKloc != null && !this.WarningSuppressionKloc.Equals(input.WarningSuppressionKloc))) return false;

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
                if (this.CodeSize != null) hashCode = hashCode * 59 + this.CodeSize.GetHashCode();
                if (this.RawLines != null) hashCode = hashCode * 59 + this.RawLines.GetHashCode();
                if (this.MethodsTotal != null) hashCode = hashCode * 59 + this.MethodsTotal.GetHashCode();
                if (this.CyclomaticComplexityTotal != null) hashCode = hashCode * 59 + this.CyclomaticComplexityTotal.GetHashCode();
                if (this.CyclomaticComplexityPerMethod != null) hashCode = hashCode * 59 + this.CyclomaticComplexityPerMethod.GetHashCode();
                if (this.MaximumCyclomaticComplexity != null) hashCode = hashCode * 59 + this.MaximumCyclomaticComplexity.GetHashCode();
                if (this.HugeCyclomaticComplexityTotal != null) hashCode = hashCode * 59 + this.HugeCyclomaticComplexityTotal.GetHashCode();
                if (this.HugeCyclomaticComplexityRatio != null) hashCode = hashCode * 59 + this.HugeCyclomaticComplexityRatio.GetHashCode();
                if (this.CcaCyclomaticComplexityTotal != null) hashCode = hashCode * 59 + this.CcaCyclomaticComplexityTotal.GetHashCode();
                if (this.CcaCyclomaticComplexityPerMethod != null) hashCode = hashCode * 59 + this.CcaCyclomaticComplexityPerMethod.GetHashCode();
                if (this.MaximumCcaCyclomaticComplexity != null) hashCode = hashCode * 59 + this.MaximumCcaCyclomaticComplexity.GetHashCode();
                if (this.HugeCcaCyclomaticComplexityTotal != null) hashCode = hashCode * 59 + this.HugeCcaCyclomaticComplexityTotal.GetHashCode();
                if (this.CyclomaticComplexityAdequacy != null) hashCode = hashCode * 59 + this.CyclomaticComplexityAdequacy.GetHashCode();
                if (this.MaximumDepth != null) hashCode = hashCode * 59 + this.MaximumDepth.GetHashCode();
                if (this.HugeDepthTotal != null) hashCode = hashCode * 59 + this.HugeDepthTotal.GetHashCode();
                if (this.HugeDepthRatio != null) hashCode = hashCode * 59 + this.HugeDepthRatio.GetHashCode();
                if (this.MethodLines != null) hashCode = hashCode * 59 + this.MethodLines.GetHashCode();
                if (this.LinesPerMethod != null) hashCode = hashCode * 59 + this.LinesPerMethod.GetHashCode();
                if (this.HugeMethodTotal != null) hashCode = hashCode * 59 + this.HugeMethodTotal.GetHashCode();
                if (this.HugeMethodRatio != null) hashCode = hashCode * 59 + this.HugeMethodRatio.GetHashCode();
                if (this.FilesTotal != null) hashCode = hashCode * 59 + this.FilesTotal.GetHashCode();
                if (this.FoldersTotal != null) hashCode = hashCode * 59 + this.FoldersTotal.GetHashCode();
                if (this.LinesPerFile != null) hashCode = hashCode * 59 + this.LinesPerFile.GetHashCode();
                if (this.HugeHeaderfileTotal != null) hashCode = hashCode * 59 + this.HugeHeaderfileTotal.GetHashCode();
                if (this.HugeHeaderfileRatio != null) hashCode = hashCode * 59 + this.HugeHeaderfileRatio.GetHashCode();
                if (this.HugeNonHeaderfileTotal != null) hashCode = hashCode * 59 + this.HugeNonHeaderfileTotal.GetHashCode();
                if (this.HugeNonHeaderfileRatio != null) hashCode = hashCode * 59 + this.HugeNonHeaderfileRatio.GetHashCode();
                if (this.HugeFolderTotal != null) hashCode = hashCode * 59 + this.HugeFolderTotal.GetHashCode();
                if (this.HugeFolderRatio != null) hashCode = hashCode * 59 + this.HugeFolderRatio.GetHashCode();
                if (this.FileDuplicationTotal != null) hashCode = hashCode * 59 + this.FileDuplicationTotal.GetHashCode();
                if (this.FileDuplicationRatio != null) hashCode = hashCode * 59 + this.FileDuplicationRatio.GetHashCode();
                if (this.NonHfileDuplicationTotal != null) hashCode = hashCode * 59 + this.NonHfileDuplicationTotal.GetHashCode();
                if (this.NonHfileDuplicationRatio != null) hashCode = hashCode * 59 + this.NonHfileDuplicationRatio.GetHashCode();
                if (this.CodeDuplicationTotal != null) hashCode = hashCode * 59 + this.CodeDuplicationTotal.GetHashCode();
                if (this.CodeDuplicationRatio != null) hashCode = hashCode * 59 + this.CodeDuplicationRatio.GetHashCode();
                if (this.NonHfileCodeDuplicationTotal != null) hashCode = hashCode * 59 + this.NonHfileCodeDuplicationTotal.GetHashCode();
                if (this.NonHfileCodeDuplicationRatio != null) hashCode = hashCode * 59 + this.NonHfileCodeDuplicationRatio.GetHashCode();
                if (this.UnsafeFunctionsTotal != null) hashCode = hashCode * 59 + this.UnsafeFunctionsTotal.GetHashCode();
                if (this.UnsafeFunctionsKloc != null) hashCode = hashCode * 59 + this.UnsafeFunctionsKloc.GetHashCode();
                if (this.RedundantCodeTotal != null) hashCode = hashCode * 59 + this.RedundantCodeTotal.GetHashCode();
                if (this.RedundantCodeKloc != null) hashCode = hashCode * 59 + this.RedundantCodeKloc.GetHashCode();
                if (this.WarningSuppressionTotal != null) hashCode = hashCode * 59 + this.WarningSuppressionTotal.GetHashCode();
                if (this.WarningSuppressionKloc != null) hashCode = hashCode * 59 + this.WarningSuppressionKloc.GetHashCode();
                return hashCode;
            }
        }
    }
}
