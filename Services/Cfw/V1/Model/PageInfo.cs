using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PageInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endRow", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hasNextPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hasPreviousPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPreviousPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isFirstPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFirstPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isLastPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLastPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> List { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("navigateFirstPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? NavigateFirstPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("navigateLastPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? NavigateLastPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("navigatePages", NullValueHandling = NullValueHandling.Ignore)]
        public int? NavigatePages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("navigatepageNums", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> NavigatepageNums { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nextPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pageNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prePage", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrePage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("startRow", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageInfo {\n");
            sb.Append("  endRow: ").Append(EndRow).Append("\n");
            sb.Append("  hasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  hasPreviousPage: ").Append(HasPreviousPage).Append("\n");
            sb.Append("  isFirstPage: ").Append(IsFirstPage).Append("\n");
            sb.Append("  isLastPage: ").Append(IsLastPage).Append("\n");
            sb.Append("  list: ").Append(List).Append("\n");
            sb.Append("  navigateFirstPage: ").Append(NavigateFirstPage).Append("\n");
            sb.Append("  navigateLastPage: ").Append(NavigateLastPage).Append("\n");
            sb.Append("  navigatePages: ").Append(NavigatePages).Append("\n");
            sb.Append("  navigatepageNums: ").Append(NavigatepageNums).Append("\n");
            sb.Append("  nextPage: ").Append(NextPage).Append("\n");
            sb.Append("  pageNum: ").Append(PageNum).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pages: ").Append(Pages).Append("\n");
            sb.Append("  prePage: ").Append(PrePage).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  startRow: ").Append(StartRow).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PageInfo input)
        {
            if (input == null) return false;
            if (this.EndRow != input.EndRow || (this.EndRow != null && !this.EndRow.Equals(input.EndRow))) return false;
            if (this.HasNextPage != input.HasNextPage || (this.HasNextPage != null && !this.HasNextPage.Equals(input.HasNextPage))) return false;
            if (this.HasPreviousPage != input.HasPreviousPage || (this.HasPreviousPage != null && !this.HasPreviousPage.Equals(input.HasPreviousPage))) return false;
            if (this.IsFirstPage != input.IsFirstPage || (this.IsFirstPage != null && !this.IsFirstPage.Equals(input.IsFirstPage))) return false;
            if (this.IsLastPage != input.IsLastPage || (this.IsLastPage != null && !this.IsLastPage.Equals(input.IsLastPage))) return false;
            if (this.List != input.List || (this.List != null && input.List != null && !this.List.SequenceEqual(input.List))) return false;
            if (this.NavigateFirstPage != input.NavigateFirstPage || (this.NavigateFirstPage != null && !this.NavigateFirstPage.Equals(input.NavigateFirstPage))) return false;
            if (this.NavigateLastPage != input.NavigateLastPage || (this.NavigateLastPage != null && !this.NavigateLastPage.Equals(input.NavigateLastPage))) return false;
            if (this.NavigatePages != input.NavigatePages || (this.NavigatePages != null && !this.NavigatePages.Equals(input.NavigatePages))) return false;
            if (this.NavigatepageNums != input.NavigatepageNums || (this.NavigatepageNums != null && input.NavigatepageNums != null && !this.NavigatepageNums.SequenceEqual(input.NavigatepageNums))) return false;
            if (this.NextPage != input.NextPage || (this.NextPage != null && !this.NextPage.Equals(input.NextPage))) return false;
            if (this.PageNum != input.PageNum || (this.PageNum != null && !this.PageNum.Equals(input.PageNum))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Pages != input.Pages || (this.Pages != null && !this.Pages.Equals(input.Pages))) return false;
            if (this.PrePage != input.PrePage || (this.PrePage != null && !this.PrePage.Equals(input.PrePage))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.StartRow != input.StartRow || (this.StartRow != null && !this.StartRow.Equals(input.StartRow))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.EndRow != null) hashCode = hashCode * 59 + this.EndRow.GetHashCode();
                if (this.HasNextPage != null) hashCode = hashCode * 59 + this.HasNextPage.GetHashCode();
                if (this.HasPreviousPage != null) hashCode = hashCode * 59 + this.HasPreviousPage.GetHashCode();
                if (this.IsFirstPage != null) hashCode = hashCode * 59 + this.IsFirstPage.GetHashCode();
                if (this.IsLastPage != null) hashCode = hashCode * 59 + this.IsLastPage.GetHashCode();
                if (this.List != null) hashCode = hashCode * 59 + this.List.GetHashCode();
                if (this.NavigateFirstPage != null) hashCode = hashCode * 59 + this.NavigateFirstPage.GetHashCode();
                if (this.NavigateLastPage != null) hashCode = hashCode * 59 + this.NavigateLastPage.GetHashCode();
                if (this.NavigatePages != null) hashCode = hashCode * 59 + this.NavigatePages.GetHashCode();
                if (this.NavigatepageNums != null) hashCode = hashCode * 59 + this.NavigatepageNums.GetHashCode();
                if (this.NextPage != null) hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PageNum != null) hashCode = hashCode * 59 + this.PageNum.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Pages != null) hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.PrePage != null) hashCode = hashCode * 59 + this.PrePage.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.StartRow != null) hashCode = hashCode * 59 + this.StartRow.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
