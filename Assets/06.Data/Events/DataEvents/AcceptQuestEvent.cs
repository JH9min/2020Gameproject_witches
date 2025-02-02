﻿using System;
using JetBrains.Annotations;

public class AcceptQuestEvent : CustomEvent
{
        private FlagID _flagID;

        public AcceptQuestEvent([CanBeNull] QuestDetailProto proto,String id)
        {
                _flagID=(FlagID)Enum.Parse(typeof(FlagID), id);
        }


        public void StartEvent(OnInteract action)
        {
                Quest.SetFlag(_flagID);
                action.SetActionDone();
        }


}