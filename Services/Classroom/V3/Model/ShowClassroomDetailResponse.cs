using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowClassroomDetailResponse : SdkResponse
    {

        /// <summary>
        /// 课堂名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 课堂描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 课堂公告
        /// </summary>
        [JsonProperty("announcement", NullValueHandling = NullValueHandling.Ignore)]
        public string Announcement { get; set; }

        /// <summary>
        /// 课堂公告创建时间，日期格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("announcement_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AnnouncementTime { get; set; }

        /// <summary>
        /// 课堂创建时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 课堂最新更新时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 当前课堂的授课人
        /// </summary>
        [JsonProperty("teacher", NullValueHandling = NullValueHandling.Ignore)]
        public string Teacher { get; set; }

        /// <summary>
        /// 课堂学分
        /// </summary>
        [JsonProperty("credit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Credit { get; set; }

        /// <summary>
        /// 课堂开始时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 课堂结束时间，日期格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前用户在课堂下角色，取值范围：teacher：老师，student：学生
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 授课学校
        /// </summary>
        [JsonProperty("school", NullValueHandling = NullValueHandling.Ignore)]
        public string School { get; set; }

        /// <summary>
        /// 课堂下目录数量
        /// </summary>
        [JsonProperty("content_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentCount { get; set; }

        /// <summary>
        /// 课堂下课件数量
        /// </summary>
        [JsonProperty("courseware_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoursewareCount { get; set; }

        /// <summary>
        /// 课堂下作业数量
        /// </summary>
        [JsonProperty("job_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobCount { get; set; }

        /// <summary>
        /// 课堂下成员数量
        /// </summary>
        [JsonProperty("member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// 课堂当前的状态，normal：课堂处于正常状态，archive：课堂已归档
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClassroomDetailResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  announcement: ").Append(Announcement).Append("\n");
            sb.Append("  announcementTime: ").Append(AnnouncementTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  teacher: ").Append(Teacher).Append("\n");
            sb.Append("  credit: ").Append(Credit).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  school: ").Append(School).Append("\n");
            sb.Append("  contentCount: ").Append(ContentCount).Append("\n");
            sb.Append("  coursewareCount: ").Append(CoursewareCount).Append("\n");
            sb.Append("  jobCount: ").Append(JobCount).Append("\n");
            sb.Append("  memberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClassroomDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClassroomDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Announcement == input.Announcement ||
                    (this.Announcement != null &&
                    this.Announcement.Equals(input.Announcement))
                ) && 
                (
                    this.AnnouncementTime == input.AnnouncementTime ||
                    (this.AnnouncementTime != null &&
                    this.AnnouncementTime.Equals(input.AnnouncementTime))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.Teacher == input.Teacher ||
                    (this.Teacher != null &&
                    this.Teacher.Equals(input.Teacher))
                ) && 
                (
                    this.Credit == input.Credit ||
                    (this.Credit != null &&
                    this.Credit.Equals(input.Credit))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.ContentCount == input.ContentCount ||
                    (this.ContentCount != null &&
                    this.ContentCount.Equals(input.ContentCount))
                ) && 
                (
                    this.CoursewareCount == input.CoursewareCount ||
                    (this.CoursewareCount != null &&
                    this.CoursewareCount.Equals(input.CoursewareCount))
                ) && 
                (
                    this.JobCount == input.JobCount ||
                    (this.JobCount != null &&
                    this.JobCount.Equals(input.JobCount))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Announcement != null)
                    hashCode = hashCode * 59 + this.Announcement.GetHashCode();
                if (this.AnnouncementTime != null)
                    hashCode = hashCode * 59 + this.AnnouncementTime.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Teacher != null)
                    hashCode = hashCode * 59 + this.Teacher.GetHashCode();
                if (this.Credit != null)
                    hashCode = hashCode * 59 + this.Credit.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.ContentCount != null)
                    hashCode = hashCode * 59 + this.ContentCount.GetHashCode();
                if (this.CoursewareCount != null)
                    hashCode = hashCode * 59 + this.CoursewareCount.GetHashCode();
                if (this.JobCount != null)
                    hashCode = hashCode * 59 + this.JobCount.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
