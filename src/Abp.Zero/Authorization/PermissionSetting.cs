﻿using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Abp.Authorization
{
    /// <summary>
    /// Used to grant/deny a permission for a role or user.
    /// <see cref="RoleId"/> or <see cref="UserId"/> must be filled.
    /// </summary>
    public class PermissionSetting : CreationAuditedEntity<long>
    {
        /// <summary>
        /// Maximum length of the <see cref="Name"/> field.
        /// </summary>
        public const int MaxNameLength = 128;

        /// <summary>
        /// Role Id.
        /// It's required if <see cref="UserId"/> is null.
        /// </summary>
        public virtual int? RoleId { get; set; }

        /// <summary>
        /// User Id.
        /// It's required if <see cref="RoleId"/> is null.
        /// </summary>
        public virtual long? UserId { get; set; }

        /// <summary>
        /// Unique name of the permission.
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        /// <summary>
        /// Is this role granted for this permission.
        /// Default value: true.
        /// </summary>
        public virtual bool IsGranted { get; set; }

        /// <summary>
        /// Creates a new <see cref="PermissionSetting"/> entity.
        /// </summary>
        public PermissionSetting()
        {
            IsGranted = true;
        }
    }
}
