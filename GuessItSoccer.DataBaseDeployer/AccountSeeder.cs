﻿using DomainDrivenDatabaseDeployer;
using GuessItSoccer.Domain.Entities;
using GuessItSoccer.Domain.Services;
using NHibernate;
using System.Collections.Generic;

namespace GuessItSoccer.DataBaseDeployer
{
    public class AccountSeeder: IDataSeeder
    {
        private readonly ISession _session;

        public AccountSeeder(ISession session)
        {
            _session = session;
        }

        public void Seed()
        {
            IEncryption encrypter = new Sha256Encrypter();
            var account = new Account
            {
                IsArchived = false,
                Email = "admin@jcespinoza.com",
                Name = "Juan Carlos Espinoza",
                Password = encrypter.Encrypt("secretPassword"),
                Role = "admin"
            };
            _session.Save(account);

            var account2 = new Account
            {
                IsArchived = false,
                Email = "jcespinozahz@live.com",
                Name = "Juan Carlos Espinoza",
                Password = encrypter.Encrypt("secretPassword"),
                Role = "user"
            };
            _session.Save(account2);
        }
    }
}
