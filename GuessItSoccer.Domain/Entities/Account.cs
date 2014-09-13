﻿using System.Collections.Generic;
using System.Linq;
using GuessItSoccer.Domain.Services;

namespace GuessItSoccer.Domain.Entities
{
    public class Account: IEntity
    {
        public virtual long Id { get; set; }

        public virtual bool IsArchived { get; set; }

        public virtual string Email { get; set; }

        public virtual string Name { get; set; }

        public virtual string Password { get; set; }

        //private IEnumerable<League> _leagues = new List<League>();

        public virtual IEnumerable<Prediction> Predictions { get; set; }
        //public virtual IEnumerable<League> Leagues
        //{
        //    get { return _leagues; }
        //    protected set { this._leagues = value; }
        //}

        //public virtual void AddLeagues(League league)
        //{
        //    if (Leagues.All(x => x.Id == league.Id))
        //    {
        //        ((IList<League>)Leagues).Add(league);
        //    }
        //}

        //public virtual void RemoveLeagues(long leagueId)
        //{
        //    var league = Leagues.FirstOrDefault(x => x.Id == leagueId);
        //    if (league != null)
        //    {
        //        ((IList<League>) Leagues).Remove(league);
        //    }
        //}

        public virtual bool PasswordsEqual(string testPassword)
        {
            IEncryption encryptor = new Sha256Encrypter();
            string hashedTestPassword = encryptor.Encrypt(testPassword);
            return (Password == hashedTestPassword);
        }
    }
}
