﻿using HSDRaw.Common;
using HSDRaw.Common.Animation;

namespace HSDRaw.MEX.Menus
{
    public class MEX_Menu : HSDAccessor
    {
        public override int TrimmedSize => 0x10;

        public HSDArrayAccessor<MEX_Menu_NameFrames> AnimationValues { get => _s.GetReference<HSDArrayAccessor<MEX_Menu_NameFrames>>(0x00); set => _s.SetReference(0x00, value); }

        public HSDArrayAccessor<MEX_Menu_Definition> MenuDef { get => _s.GetReference<HSDArrayAccessor<MEX_Menu_Definition>>(0x04); set => _s.SetReference(0x04, value); }

        public HSD_MatAnimJoint OptionTextures { get => _s.GetReference<HSD_MatAnimJoint>(0x08); set => _s.SetReference(0x08, value); }

        public HSD_MatAnimJoint MenuTextures { get => _s.GetReference<HSD_MatAnimJoint>(0x0C); set => _s.SetReference(0x0C, value); }
    }

    public class MEX_Menu_NameFrames : HSDAccessor
    {
        public override int TrimmedSize => 0x0C;

        public float StartFrame { get => _s.GetFloat(0x00); set => _s.SetFloat(0x00, value); }

        public float EndFrame { get => _s.GetFloat(0x04); set => _s.SetFloat(0x04, value); }

        public float LoopFrame { get => _s.GetFloat(0x08); set => _s.SetFloat(0x08, value); }
    }

    public class MEX_Menu_Definition : HSDAccessor
    {
        public override int TrimmedSize => 0x18;

        public HSDArrayAccessor<MEX_Menu_NameFrames> MenuPreviewFrames { get => _s.GetReference<HSDArrayAccessor<MEX_Menu_NameFrames>>(0x00); set => _s.SetReference(0x00, value); }

        public float FirstOption { get => _s.GetFloat(0x04); set => _s.SetFloat(0x04, value); }

        public HSDArrayAccessor<HSD_UShort> DescriptionTextIDs { get => _s.GetReference<HSDArrayAccessor<HSD_UShort>>(0x08); set => _s.SetReference(0x08, value); }

        public byte NumberOfOptions { get => _s.GetByte(0x0C); set => _s.SetByte(0x0C, value); }

        public int MenuThink { get => _s.GetInt32(0x10); set => _s.SetInt32(0x10, value); }

        public HSDArrayAccessor<MEX_Menu_OptionDef> OptionDefs { get => _s.GetReference<HSDArrayAccessor<MEX_Menu_OptionDef>>(0x14); set => _s.SetReference(0x14, value); }
    }

    public class MEX_Menu_OptionDef : HSDAccessor
    {
        public override int TrimmedSize => 0x02;

        public byte Kind { get => _s.GetByte(0x00); set => _s.SetByte(0x00, value); }

        public byte ID { get => _s.GetByte(0x01); set => _s.SetByte(0x01, value); }
    }
}
