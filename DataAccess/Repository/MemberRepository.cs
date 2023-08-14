using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member SignIn(string email, string password) => MemberDAO.Instance.SignIn(email, password);
        public void AddMember(Member member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public void DeleteMember(int memberID)
        {
            MemberDAO.Instance.RemoveMember(memberID);
        }

        public IEnumerable<Member> FilterMember(string city, string country)
        {
            return MemberDAO.Instance.Filter(city, country);
        }

        public Member GetLast()
        {
            return MemberDAO.Instance.GetLast();
        }

        public Member GetMemberbyEmail(string memberEmail)
        {
            return MemberDAO.Instance.GetMemberbyEmail(memberEmail);
        }

        public Member GetMemberbyID(int memberID)
        {
            return MemberDAO.Instance.GetMemberbyId(memberID);
        }

        public IEnumerable<Member> GetMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }

        public IEnumerable<Member> SearchMembers(int id, string name)
        {
            return MemberDAO.Instance.Search(id, name);
        }

        public void UpdateMember(Member member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
