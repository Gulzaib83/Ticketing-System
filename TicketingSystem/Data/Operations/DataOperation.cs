using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Operations
{
    public class DataOperation
    {
        public Boolean CreateUser(User user)
        {
            try
            {
                using (var context = new TicketContext())
                {

                    context.Users.Add(user);
                }
            }
            catch(Exception ex)
            {
                //To Do//
                // Exceptions shall be logged in DB / File
                return false;   
            }
            return true;
        }

        public List<User> GetRegisteredUsers()
        {
            List<User> users = new List<User>();    
            try
            {
                using (var context = new TicketContext())
                {

                    users = context.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                //To Do//
                // Exceptions shall be logged in DB / File
                return null;
            }
            return users;

        }

        public List<Route> GetRouts()
        {
            List<Route> routes = new List<Route>();
            try
            {
                using (var context = new TicketContext())
                {

                    routes = context.Routes.ToList();
                }
            }
            catch (Exception ex)
            {
                //To Do//
                // Exceptions shall be logged in DB / File
                return null;
            }
            return routes;  
        }

        public Boolean GenerateTicket(Ticket ticket)
        {
            try
            {
                using (var context = new TicketContext())
                {

                    context.Tickets.Add(ticket);
                }
            }
            catch (Exception ex)
            {
                //To Do//
                // Exceptions shall be logged in DB / File
                return false;
            }
            return true;
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            try
            {
                using (var context = new TicketContext())
                {

                    tickets = context.Tickets.ToList();
                }
            }
            catch (Exception ex)
            {
                //To Do//
                // Exceptions shall be logged in DB / File
                return null;
            }
            return tickets;
        }
    }
}
