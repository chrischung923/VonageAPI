using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Vonage;
using Vonage.Request;
using Vonage.Voice;
using Vonage.Voice.EventWebhooks;
using Vonage.Voice.Nccos;
using Vonage.Voice.Nccos.Endpoints;
using VonageAPI.Entities;
using VonageAPI.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using VonageAPI.EntitiesWebCms;

namespace VonageAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VonageController : ControllerBase
    {
        vonageContext dbcontext = new vonageContext();
        webcmsContext dbcontext_webcoms = new webcmsContext();

        private readonly IHostingEnvironment _hostingEnvironment;


        public VonageController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Route("vonageevent")]
        public IActionResult vonageevent([FromBody] dynamic data)
        {
            var e = Vonage.Voice.EventWebhooks.CallStatusEvent.ParseEvent(data.ToString());

            VonageEvent eventData = new VonageEvent();

            //if (e is Vonage.Voice.EventWebhooks.Started)
            //{
            //    var statusStarted = e as Started;
            //    eventData.Id = 0;
            //    eventData.TelFrom = statusStarted.From;
            //    eventData.UserFrom = statusStarted.From;
            //    eventData.TelTo = statusStarted.To;
            //    eventData.UserTo = statusStarted.To;
            //    eventData.Uuid = statusStarted.Uuid;
            //    eventData.ConversationUuid = statusStarted.ConversationUuid;
            //    eventData.Status = statusStarted.Status;
            //    eventData.Direction = statusStarted.Direction.ToString();
            //    eventData.Timestamp = DateTime.Now;
            //    eventData.StartTime = "";
            //    eventData.EndTime = "";
            //    eventData.Duration = "";
            //    eventData.Rate = "";
            //    eventData.Network = "";
            //    eventData.Detail = "";

            //    dbcontext.VonageEvent.Add(eventData);
            //    dbcontext.SaveChanges();

            //}

            //if (e is Vonage.Voice.EventWebhooks.Ringing)
            //{
            //    var statusRinging = e as Ringing;
            //    eventData.Id = 0;
            //    eventData.TelFrom = statusRinging.From;
            //    eventData.UserFrom = statusRinging.From;
            //    eventData.TelTo = statusRinging.To;
            //    eventData.UserTo = statusRinging.To;
            //    eventData.Uuid = statusRinging.Uuid;
            //    eventData.ConversationUuid = statusRinging.ConversationUuid;
            //    eventData.Status = statusRinging.Status;
            //    eventData.Direction = statusRinging.Direction.ToString();
            //    eventData.Timestamp = DateTime.Now;
            //    eventData.StartTime = "";
            //    eventData.EndTime = "";
            //    eventData.Duration = "";
            //    eventData.Rate = "";
            //    eventData.Network = "";
            //    eventData.Detail = "";

            //    dbcontext.VonageEvent.Add(eventData);
            //    dbcontext.SaveChanges();
            //}

            try
            {
                if (e is Vonage.Voice.EventWebhooks.Answered)
                {
                    var statusAnswered = e as Answered;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusAnswered.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid2 = statusAnswered.Uuid;
                    existinginfo.Status2 = statusAnswered.Status;
                    existinginfo.Timestamp2 = statusAnswered.TimeStamp;
                    existinginfo.LatestStatus = statusAnswered.Status;

                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Busy)
                {
                    var statusBusy = e as Busy;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusBusy.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid3 = statusBusy.Uuid;
                    existinginfo.Status3 = statusBusy.Status;
                    existinginfo.Timestamp3 = statusBusy.TimeStamp;
                    existinginfo.LatestStatus = statusBusy.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Cancelled)
                {
                    var statusCancelled = e as Cancelled;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusCancelled.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid4 = statusCancelled.Uuid;
                    existinginfo.Status4 = statusCancelled.Status;
                    existinginfo.Timestamp4 = statusCancelled.TimeStamp;
                    existinginfo.LatestStatus = statusCancelled.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Unanswered)
                {
                    var statusUnanswered = e as Unanswered;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusUnanswered.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid5 = statusUnanswered.Uuid;
                    existinginfo.Status5 = statusUnanswered.Status;
                    existinginfo.Timestamp5 = statusUnanswered.TimeStamp;
                    existinginfo.LatestStatus = statusUnanswered.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Disconnected)
                {
                    var statusDisconnected = e as Disconnected;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusDisconnected.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid6 = statusDisconnected.Uuid;
                    existinginfo.Status6 = statusDisconnected.Status;
                    existinginfo.Timestamp6 = statusDisconnected.TimeStamp;
                    existinginfo.LatestStatus = statusDisconnected.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Rejected)
                {
                    var statusRejected = e as Rejected;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusRejected.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid7 = statusRejected.Uuid;
                    existinginfo.Status7 = statusRejected.Status;
                    existinginfo.Timestamp7 = statusRejected.TimeStamp;
                    existinginfo.LatestStatus = statusRejected.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Failed)
                {
                    var statusFailed = e as Failed;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusFailed.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid8 = statusFailed.Uuid;
                    existinginfo.Status8 = statusFailed.Status;
                    existinginfo.Timestamp8 = statusFailed.TimeStamp;
                    existinginfo.LatestStatus = statusFailed.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Timeout)
                {
                    var statusTimeout = e as Timeout;
                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusTimeout.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid9 = statusTimeout.Uuid;
                    existinginfo.Status9 = statusTimeout.Status;
                    existinginfo.Timestamp9 = statusTimeout.TimeStamp;
                    existinginfo.LatestStatus = statusTimeout.Status;
                    dbcontext.SaveChanges();
                }

                if (e is Vonage.Voice.EventWebhooks.Completed)
                {
                    
                    var statusCompleted = e as Completed;

                    var existinginfo = dbcontext.VonageEvent.Where(f => f.ConversationUuid == statusCompleted.ConversationUuid).FirstOrDefault();

                    existinginfo.Uuid10 = statusCompleted.Uuid;
                    existinginfo.Status10 = statusCompleted.Status;
                    existinginfo.Timestamp10 = statusCompleted.TimeStamp;
                    existinginfo.EndTime = DateTime.Now;
                    existinginfo.Duration = statusCompleted.Duration;
                    existinginfo.Rate = statusCompleted.Rate;
                    existinginfo.Network = statusCompleted.Network;
                    existinginfo.Detail = statusCompleted.DetailString;
                    existinginfo.LatestStatus = statusCompleted.Status;

                    dbcontext.SaveChanges();
                }



                return Ok(e);
            }
            catch (Exception ex)
            {

                return Ok(ex.Message);
            }

        }
       
        [HttpPost]
        [Route("Call")]
        public async Task<IActionResult> CreateCall([FromForm]CallModel info) {
            IDictionary<string, string> ConversationUuid = new Dictionary<string, string>();
            try { 
            var rootPath = _hostingEnvironment.ContentRootPath;
            var PrivateKeyPath = Path.Combine(rootPath, "Key/private.key");

            var creds = Credentials.FromAppIdAndPrivateKeyPath("a8dfd2b0-6ab0-49ac-b806-a83bc16d7b39", PrivateKeyPath);
            var vonage = new VonageClient(creds);
            var voiceClient = vonage.VoiceClient;

                var vonageEndpoint = new PhoneEndpoint()
            {
                Number = "85230020910"  //必須是Vonage上登記的電話
            };

            var fromEndpoint = new PhoneEndpoint()
            {
                Number = info.StaffTelNo //同事電話 (Sender)
            };

            var toEndpoint = new PhoneEndpoint()
            {
                Number = info.ClientTel //客人電話 (Receiver)
            };

            var ncco = new Ncco(
            //Optional -1 : 接通Sender電話後會先播放一段文字語音 

            //new TalkAction()
            //{
            //    Style=0,
            //    Language="yue_HK",
            //    Text = "你好, 我將會幫你打俾李先生, 請稍等",
            //},

            //Optional -2 : 接通Sender電話後會先播放一段mp3 
            //new StreamAction()  {
            //  StreamUrl=new[] {
            //  "https://samplelib.com/lib/preview/mp3/sample-12s.mp3"
            //  },
            //},

            new ConnectAction()
            {
                From = vonageEndpoint.Number, //客人電話 (Receiver) 來電顯示號碼
                Endpoint = new[] {
                toEndpoint,
                }
            });

            var command = new CallCommand()
            {
                From = vonageEndpoint,
                To = new[] {
            fromEndpoint
            },
                Ncco = ncco
            };

            var response = await voiceClient.CreateCallAsync(command);
              
                if (!string.IsNullOrEmpty(response.Status))
                {

                    VonageEvent eventData = new VonageEvent();
                    eventData.Id = 0;
                    eventData.BranchName = info.BranchName;
                    eventData.StaffEmail = info.Email;
                    eventData.TelFrom = info.StaffTelNo;
                    eventData.UserFrom = info.StaffName;
                    eventData.TelTo = info.ClientTel;
                    eventData.UserTo = info.ClientName;
                    eventData.ConversationUuid = response.ConversationUuid;
                    eventData.Direction = response.Direction.ToString();
                    eventData.Uuid1 = response.Uuid;                   
                    eventData.Status1 = response.Status;
                    eventData.Timestamp1 = DateTime.Now;
                    eventData.Uuid2 = "";
                    eventData.Status2 = "";
                    eventData.Timestamp2 = null;
                    eventData.Uuid3 = "";
                    eventData.Status3 = "";
                    eventData.Timestamp3 = null;
                    eventData.Uuid4 = "";
                    eventData.Status4 = "";
                    eventData.Timestamp4 = null;
                    eventData.Uuid5 = "";
                    eventData.Status5 = "";
                    eventData.Timestamp5 = null;
                    eventData.Uuid6 = "";
                    eventData.Status6 = "";
                    eventData.Timestamp6 = null;
                    eventData.Uuid7 = "";
                    eventData.Status7 = "";
                    eventData.Timestamp7 = null;
                    eventData.Uuid8 = "";
                    eventData.Status8 = "";
                    eventData.Timestamp8 = null;
                    eventData.Uuid9 = "";
                    eventData.Status9 = "";
                    eventData.Timestamp9 = null;
                    eventData.Uuid10 = "";
                    eventData.Status10 = "";
                    eventData.Timestamp10 = null;                             
                    eventData.StartTime = DateTime.Now;
                    eventData.EndTime = null;
                    eventData.Duration = "";
                    eventData.Rate = "";
                    eventData.Network = "";
                    eventData.Detail = "";
                    eventData.LatestStatus = "started";

                    dbcontext.VonageEvent.Add(eventData);
                    dbcontext.SaveChanges();
                }
               
                ConversationUuid.Add("CUuid", response.ConversationUuid);

            } catch (Exception ex) {
                //ConversationUuid.Add("Exception", ex.Message);
                ConversationUuid.Add("clientno", info.ClientTel);
            }
            return Ok(ConversationUuid);
        }

        [EnableCors("CorsPolicy")]
        [HttpPost]
        [Route("TestDB")]        
        public IActionResult CreateCall2([FromBody] CallModel info)
        {
            IDictionary<string, string> ConversationUuid = new Dictionary<string, string>();
            var remoteIp = Request.HttpContext.Connection.LocalIpAddress.ToString();
            try
            {
                VonageEvent eventData = new VonageEvent();
                eventData.Id = 0;
                eventData.BranchName = info.BranchName;
                eventData.StaffEmail = info.Email;
                eventData.TelFrom = info.StaffTelNo;
                eventData.UserFrom = info.StaffName;
                eventData.TelTo = info.ClientTel;
                eventData.UserTo = info.ClientName;
                eventData.ConversationUuid = "CON-5055403f-db62-48da-a83d-e3099255d44q";
                eventData.Direction = "outbound";
                eventData.Uuid1 = "bc65058e-af96-4200-a369-5621084540ec";
                eventData.Status1 = "started";
                eventData.Timestamp1 = DateTime.Now;
                eventData.Uuid2 = "";
                eventData.Status2 = "";
                eventData.Timestamp2 = null;
                eventData.Uuid3 = "";
                eventData.Status3 = "";
                eventData.Timestamp3 = null;
                eventData.Uuid4 = "";
                eventData.Status4 = "";
                eventData.Timestamp4 = null;
                eventData.Uuid5 = "";
                eventData.Status5 = "";
                eventData.Timestamp5 = null;
                eventData.Uuid6 = "";
                eventData.Status6 = "";
                eventData.Timestamp6 = null;
                eventData.Uuid7 = "";
                eventData.Status7 = "";
                eventData.Timestamp7 = null;
                eventData.Uuid8 = "";
                eventData.Status8 = "";
                eventData.Timestamp8 = null;
                eventData.Uuid9 = "";
                eventData.Status9 = "";
                eventData.Timestamp9 = null;
                eventData.Uuid10 = "";
                eventData.Status10 = "";
                eventData.Timestamp10 = null;
                eventData.StartTime = null;
                eventData.EndTime = null;
                eventData.Duration = "";
                eventData.Rate = "";
                eventData.Network = "";
                eventData.Detail = remoteIp;
                eventData.LatestStatus = "started";

                dbcontext.VonageEvent.Add(eventData);
                dbcontext.SaveChanges();

                ConversationUuid.Add("CUuid", "CON-5055403f-db62-48da-a83d-e3099255d44q" + "/" + remoteIp);
            }
            catch (Exception ex)
            {
                ConversationUuid.Add("Exception", ex.Message);
            }
            return Ok(ConversationUuid);

        }
        
        [Route("Status")]
        public IActionResult CallStatus(String ConversationUuid)
        {
            IDictionary<string, string> LatestStatus = new Dictionary<string, string>();
            var result = dbcontext.VonageEvent.Where(f => f.ConversationUuid == ConversationUuid).Select(f=>f.LatestStatus).FirstOrDefault();
            LatestStatus.Add("status",result);
            return Ok(LatestStatus);

        }

        [HttpPost]
        [Route("answer")]
        public IActionResult Answer([FromBody]inboundCallModel data)
        {
            var handlerNumber = "85238553011";
            var vonageNumber = "85230020910";
            string branchName = "office";
            string handlerName = "office";
            string handlerEmail = "it_support@century21-goodwin.com";
            string senderName = "";
            string handlerinfo = "0";

            var lastHandler = dbcontext.VonageEvent.Where(f => f.TelTo == data.from && f.Direction == "outbound").OrderByDescending(f => f.Timestamp10).Take(1).ToList();

            if (lastHandler.Count > 0){
                var HandlerInfo = dbcontext_webcoms.CmsAgent.Where(f => f.Tel.Trim() == lastHandler[0].TelFrom.Substring(3).Trim()).Take(1).ToList();
                //handlerinfo = lastHandler[0].TelFrom.Substring(3).Trim();

                if (HandlerInfo.Count > 0) {
                    
                    if (HandlerInfo[0].Status == "active")
                    {
                        handlerNumber = lastHandler[0].TelFrom;
                        branchName = lastHandler[0].BranchName;
                        handlerName = lastHandler[0].UserFrom;
                        handlerEmail = lastHandler[0].StaffEmail;
                        senderName = lastHandler[0].UserTo;
                    }
                    else {
                        if (HandlerInfo[0].UpManager != 0)
                        {
                            var HandlerManagerInfo = dbcontext_webcoms.CmsAgent.Where(f => f.Id == HandlerInfo[0].UpManager).Take(1).ToList();
                            var ManagerbranchName = dbcontext_webcoms.CmsBranch.Where(f => f.Id == HandlerManagerInfo[0].BranchId).Select(f => f.NameTc).Take(1).FirstOrDefault();

                            handlerNumber = "852"+HandlerManagerInfo[0].Tel;
                            branchName = ManagerbranchName;
                            handlerName = HandlerManagerInfo[0].NameEn;
                            handlerEmail = HandlerManagerInfo[0].Email;
                            senderName = lastHandler[0].UserTo;
                        }
                        //else if (HandlerInfo[0].UpManager == 0 && HandlerInfo[0].UpDmanager != 0)
                        //{
                        //    var HandlerDManagerInfo = dbcontext_webcoms.CmsAgent.Where(f => f.Id == HandlerInfo[0].UpDmanager).Take(1).ToList();
                        //    var DManagerbranchName = dbcontext_webcoms.CmsBranch.Where(f => f.Id == HandlerDManagerInfo[0].BranchId).Select(f => f.NameTc).Take(1).FirstOrDefault();

                        //    handlerNumber = HandlerDManagerInfo[0].Tel;
                        //    branchName = DManagerbranchName;
                        //    handlerName = HandlerDManagerInfo[0].NameEn;
                        //    handlerEmail = HandlerDManagerInfo[0].Email;
                        //    senderName = lastHandler[0].UserTo;
                        //}

                    }
                }
       
            }

            VonageEvent eventData = new VonageEvent();
            eventData.Id = 0;
            eventData.BranchName = branchName;
            eventData.StaffEmail = handlerEmail;
            eventData.TelFrom = data.from;
            eventData.UserFrom = senderName;
            eventData.TelTo = handlerNumber;
            eventData.UserTo = handlerName;
            eventData.ConversationUuid = data.conversation_uuid;
            eventData.Direction = "Inbound";
            eventData.Uuid1 = data.uuid;
            eventData.Status1 = "started";
            eventData.Timestamp1 = DateTime.Now;
            eventData.Uuid2 = "";
            eventData.Status2 = "";
            eventData.Timestamp2 = null;
            eventData.Uuid3 = "";
            eventData.Status3 = "";
            eventData.Timestamp3 = null;
            eventData.Uuid4 = "";
            eventData.Status4 = "";
            eventData.Timestamp4 = null;
            eventData.Uuid5 = "";
            eventData.Status5 = "";
            eventData.Timestamp5 = null;
            eventData.Uuid6 = "";
            eventData.Status6 = "";
            eventData.Timestamp6 = null;
            eventData.Uuid7 = "";
            eventData.Status7 = "";
            eventData.Timestamp7 = null;
            eventData.Uuid8 = "";
            eventData.Status8 = "";
            eventData.Timestamp8 = null;
            eventData.Uuid9 = "";
            eventData.Status9 = "";
            eventData.Timestamp9 = null;
            eventData.Uuid10 = "";
            eventData.Status10 = "";
            eventData.Timestamp10 = null;
            eventData.StartTime = null;
            eventData.EndTime = null;
            eventData.Duration = "";
            eventData.Rate = "";
            eventData.Network = "";
            eventData.Detail = "";
            eventData.LatestStatus = "started";

            dbcontext.VonageEvent.Add(eventData);
            dbcontext.SaveChanges();

            var talkAction = new TalkAction()
            {
                Text = "Thank you for calling",
                VoiceName = "Kimberly"
            };

            var handlerEndpoint = new PhoneEndpoint() { Number = handlerNumber };
            var connectAction = new ConnectAction() { From = vonageNumber, Endpoint = new[] { handlerEndpoint } };

            var ncco = new Ncco(
                //talkAction,
                connectAction               
                );

            return Ok(ncco.ToString());

        }
    }
}
