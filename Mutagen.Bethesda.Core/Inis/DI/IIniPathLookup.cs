﻿using Mutagen.Bethesda.Environments.DI;
using Mutagen.Bethesda.Plugins.Meta;
using Noggog;

namespace Mutagen.Bethesda.Inis.DI;

public interface IIniPathLookup
{
    FilePath Get(GameRelease release);
    FilePath? TryGet(GameRelease release);
}

public class IniPathLookup : IIniPathLookup
{
    private readonly IGameDirectoryLookup _gameDirectoryLookup;

    public IniPathLookup(IGameDirectoryLookup gameDirectoryLookup)
    {
        _gameDirectoryLookup = gameDirectoryLookup;
    }
    
    public FilePath? TryGet(GameRelease release)
    {
        var constants = GameConstants.Get(release);
        var docsString = constants.MyDocumentsString;
        if (docsString == null)
        {
            var gameDir = _gameDirectoryLookup.TryGet(release);
            if (gameDir == null) return null;
            
            return Path.Combine(gameDir, ToIniFileName(release));
        }
        
        return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "My Games",
            docsString, 
            ToIniFileName(release));
    }
    
    public FilePath Get(GameRelease release)
    {
        var constants = GameConstants.Get(release);
        var docsString = constants.MyDocumentsString;
        if (docsString == null)
        {
            var gameDir = _gameDirectoryLookup.Get(release);
            return Path.Combine(gameDir, ToIniFileName(release));
        }
        
        return Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "My Games",
            docsString, 
            ToIniFileName(release));
    }

    public static string ToIniFileName(GameRelease release)
    {
        return $"{GameConstants.Get(release).IniName}.ini";
    }
}