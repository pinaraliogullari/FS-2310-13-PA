using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Data.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{
	public class MessageManager : IMessageService
	{
		private readonly IMapper _mapper;
		private readonly IMessageRepository _messageRepository;

		public MessageManager(IMapper mapper, IMessageRepository messageRepository)
		{
			_mapper = mapper;
			_messageRepository = messageRepository;
		}

		public async Task<Response<MessageDetailsViewModel>> CreateAsync(MessageDetailsViewModel messageDetailsViewModel)
		{
			var message = _mapper.Map<Message>(messageDetailsViewModel);
			var createdMessage = await _messageRepository.CreateAsync(message);
			if (createdMessage == null)
			{
				return Response<MessageDetailsViewModel>.Fail("MEsaj gönderilemedi.");
			}
			var createdMessageDetailsViewModel = _mapper.Map<MessageDetailsViewModel>(createdMessage);
			return Response<MessageDetailsViewModel>.Success(createdMessageDetailsViewModel);
		}

		public async Task<Response<List<MessageDetailsViewModel>>> GetAllReceivedMessageAsync(string userId, bool isRead = false)
		{
			var messageList = await _messageRepository.GetAllAsync(m => m.FromId == userId && m.IsRead==isRead);
			if (messageList.Count == 0)
			{
				var infoText = isRead ? "Okunmuş" : "Okunmamış";
				return Response<List<MessageDetailsViewModel>>.Fail($"{infoText} mesajınız bulunmamaktadır.");
			}
			var messageViewModelList = _mapper.Map<List<MessageDetailsViewModel>>(messageList);
			return Response<List<MessageDetailsViewModel>>.Success(messageViewModelList);
		}

		public async Task<Response<List<MessageDetailsViewModel>>> GetAllSentMessageAsync(string userId)
		{
			var messageList = await _messageRepository.GetAllAsync(m=>m.FromId==userId );
			if (messageList.Count == 0)
			{
				return Response<List<MessageDetailsViewModel>>.Fail("Giden kutusunda mesaj bulunamadı.");
			}
			var messageViewModelList = _mapper.Map<List<MessageDetailsViewModel>>(messageList);
			return Response<List<MessageDetailsViewModel>>.Success(messageViewModelList);
		}

		public async Task<Response<MessageDetailsViewModel>> GetByIdAsync(int id)
		{
			var message = await _messageRepository.GetByIdAsync(m => m.Id == id);
			if (message == null)
			{
				return Response<MessageDetailsViewModel>.Fail("Mesaj detayları görüntülenemiyor.");
			}
			var messageDetailsViewModel = _mapper.Map<MessageDetailsViewModel>(message);
			return Response<MessageDetailsViewModel>.Success(messageDetailsViewModel);
		}

		public async Task<Response<int>> GetMessageCountAsync(string userId, bool isRead = false)
		{
			var count = await _messageRepository.GetCount(m => m.FromId==userId && m.IsRead==isRead);
			return Response<int>.Success(count);
		}

		public async Task<Response<NoContent>> HardDeleteAsync(int id)
		{
			var message = await _messageRepository.GetByIdAsync(m => m.Id == id);
			if (message == null)
			{
				return Response<NoContent>.Fail("Silinecek mesaj bulunamadı.");
			}
			await _messageRepository.HardDeleteAsync(message);
			return Response<NoContent>.Success();
		}
	}
}
