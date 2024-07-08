﻿// <autogenerated />
namespace Devlooped.Sponsors;

/// <summary>
/// The resulting status from validation.
/// </summary>
public enum ManifestStatus
{
    /// <summary>
    /// The manifest couldn't be read at all.
    /// </summary>
    Unknown,
    /// <summary>
    /// The manifest was read and is valid (not expired and properly signed).
    /// </summary>
    Valid,
    /// <summary>
    /// The manifest was read but has expired.
    /// </summary>
    Expired,
    /// <summary>
    /// The manifest was read, but its signature is invalid.
    /// </summary>
    Invalid,
}