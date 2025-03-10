namespace Jorteck.Permissions
{
  public static class PermissionConstants
  {
    /// <summary>
    /// The data key used for IChatCommand.UserData.
    /// </summary>
    public const string ChatUserDataKey = "permission";

    // /perms, /perms help
    public const string Help = "permissions.help";

    // /perms user addgroup
    public const string UserAddGroup = "permissions.user.group.add";

    // /perms user removegroup
    public const string UserRemoveGroup = "permissions.user.group.remove";

    // /perms user addperm
    public const string UserAddPermission = "permission.user.permission.add";

    // /perms user removeperm
    public const string UserRemovePermission = "permission.user.permission.remove";

    // /perms group create
    public const string GroupCreate = "permissions.group.create";

    // /perms group delete
    public const string GroupDelete = "permissions.group.delete";

    // /perms group addinherit
    public const string GroupAddInherit = "permissions.group.inheritance.add";

    // /perms group removeinherit
    public const string GroupRemoveInherit = "permissions.group.inheritance.add";

    // /perms group addperm
    public const string GroupAddPermission = "permissions.group.permissions.add";

    // /perms group removeperm
    public const string GroupRemovePermission = "permissions.group.permissions.remove";

    // /perms reload
    public const string ReloadCommand = "permissions.manage.reload";
  }
}
