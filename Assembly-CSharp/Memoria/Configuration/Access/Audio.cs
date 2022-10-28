﻿using System;
using System.Collections.Generic;

namespace Memoria
{
    public sealed partial class Configuration
    {
        public static class Audio
        {
            public static Int32 SoundVolume
            {
                get => Instance._audio.SoundVolume;
                set => Instance._audio.SoundVolume.Value = value;
            }

            public static Int32 MusicVolume
            {
                get => Instance._audio.MusicVolume;
                set => Instance._audio.MusicVolume.Value = value;
            }

            public static Boolean LogVoiceActing => Instance._audio.LogVoiceActing;
            public static Boolean PriorityToOGG => Instance._audio.PriorityToOGG;

            public static void SaveSoundVolume()
            {
                SaveValue(Instance._audio.Name, Instance._audio.SoundVolume);
            }

            public static void SaveMusicVolume()
            {
                SaveValue(Instance._audio.Name, Instance._audio.MusicVolume);
            }

            public static string[] preventmultiplay = Instance._audio.PreventMultiPlay;
            private static Dictionary<string, UInt16> tmp;
            public static Dictionary<string, UInt16> preventMultiPlay
            {
                get
                {
                    if (tmp == null) {
                        tmp = new Dictionary<string, UInt16>();
                        foreach (string filePath in preventmultiplay)
                        {
                            tmp.Add(filePath, 0);
                        }
                    }
                    return tmp;
                }
            }
        }

        /*
            public static String[] FolderNames => Instance._mod.FolderNames;
            public static String[] AllFolderNames
            {
                get
                {
                    String[] res = new String[FolderNames.Length + 1];
                    FolderNames.CopyTo(res, 0);
                    res[FolderNames.Length] = "";
                    return res;
                }
            }
         */
    }
}