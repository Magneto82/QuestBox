using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizbeClient.DTO
{
    public class JoinGameViewModel
    {
        public Guid Ticket { get; set; }
        public System.Guid Id { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public TeamViewSmallModel Team { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public int QuestionTime { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public System.Guid CurrentQuestionId { get; set; }
        public bool IsCaptain { get; set; }
        public bool IsUsingQuestionPacket { get; set; }
    }

    public class ShortUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }

    public class TeamViewSmallModel
    {
        public TeamViewSmallModel()
        {
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string CaptainName { get; set; }
        public Nullable<System.Guid> CaptainId { get; set; }
        public Nullable<int> PlayedGames { get; set; }
        public Nullable<int> Wins { get; set; }
        public Nullable<int> Rating { get; set; }
        public bool HasTeamPassword { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<bool> IsActive { get; set; }

        public Nullable<bool> CanUserJoin { get; set; }
        public Nullable<bool> IsUserCaptain { get; set; }
        public int ActivePlayersCount { get; set; }
        public string LogoSavedFileName { get; set; }
    }
}
